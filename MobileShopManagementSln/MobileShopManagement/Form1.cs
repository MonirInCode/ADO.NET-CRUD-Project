using MobileShopManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagement
{
    public partial class Form1 : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int intMobileId = 0;
        string strPreviousImage = "";
        bool defaultImage = true;
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMobileVersionCmb();
            LoaddgvMobileList();
            Clear();
        }

        private void Clear()
        {
            txtMobileCode.Text = "";
            txtMobileName.Text = "";
            cmbVersion.SelectedIndex = 0;
            dtpLaunchDate.Value = DateTime.Now;
            rbtnSmart.Checked = true;
            chkAvailability.Checked = true;
            intMobileId = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Save";
            pictureBoxMobile.Image = Image.FromFile(Application.StartupPath + "\\images\\noimage.png");
            defaultImage = true;
            if (dgvVariant.DataSource == null)
            {
                dgvVariant.Rows.Clear();
            }
            else
            {
                dgvVariant.DataSource = (dgvVariant.DataSource as DataTable).Clone();
            }
        }

        private void LoaddgvMobileList()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewAllMobiles", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["Image"] = File.ReadAllBytes(Application.StartupPath + "\\images\\" + dr["ImagePath"].ToString());
                }
                dgvMobileList.RowTemplate.Height = 80;
                dgvMobileList.DataSource = dt;

                ((DataGridViewImageColumn)dgvMobileList.Columns[dgvMobileList.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                sda.Dispose();
            }
        }

        private void LoadMobileVersionCmb()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MobileVersion", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow topRow = dt.NewRow();
                topRow[0] = 0;
                topRow[1] = "--Select--";
                dt.Rows.InsertAt(topRow, 0);
                cmbVersion.ValueMember = "MobileVersionId";
                cmbVersion.DisplayMember = "MobileVersionTitle";
                cmbVersion.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png,.png)|*.png;*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMobile.Image = new Bitmap(ofd.FileName);
                if (intMobileId == 0)
                {
                    defaultImage = false;
                    strPreviousImage = "";
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pictureBoxMobile.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
            defaultImage = true;
            strPreviousImage = "";
        }
        bool ValidateMasterDetailForm()
        {
            bool isValid = true;
            if (txtMobileName.Text.Trim() == "")
            {
                MessageBox.Show("Mobile name is required");
                isValid = false;
            }
            return isValid;
        }
        string SaveImage(string imgPath)
        {
            string fileName = Path.GetFileNameWithoutExtension(imgPath);
            string ext = Path.GetExtension(imgPath);
            fileName = fileName.Length <= 15 ? fileName : fileName.Substring(0, 15);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + ext;
            pictureBoxMobile.Image.Save(Application.StartupPath + "\\images\\" + fileName);
            return fileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateMasterDetailForm())
            {
                int mblId = 0;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("MobileAddOrEdit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MobileId", intMobileId);
                    cmd.Parameters.AddWithValue("@MobileModel", txtMobileCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobileName", txtMobileName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobileVersion", Convert.ToInt16(cmbVersion.SelectedValue));
                    cmd.Parameters.AddWithValue("@LaunchDate", dtpLaunchDate.Value);
                    cmd.Parameters.AddWithValue("@IsStock", chkAvailability.Checked ? "True" : "False");
                    cmd.Parameters.AddWithValue("@MobileType", rbtnSmart.Checked ? "Smart" : "Button");
                    if (defaultImage)
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    }

                    else if (intMobileId > 0 && strPreviousImage != "")
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                        if (ofd.FileName != strPreviousImage)
                        {
                            var filename = Application.StartupPath + "\\images\\" + strPreviousImage;
                            if (pictureBoxMobile.Image != null)
                            {
                                pictureBoxMobile.Image.Dispose();
                                pictureBoxMobile.Image = null;
                                System.IO.File.Delete(filename);
                            }
                        }

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                    }
                    mblId = Convert.ToInt16(cmd.ExecuteScalar());
                }
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    foreach (DataGridViewRow item in dgvVariant.Rows)
                    {
                        if (item.IsNewRow) break;
                        else
                        {
                            SqlCommand cmd = new SqlCommand("MblVariantAddAndEdit", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@VariantId", Convert.ToInt32(item.Cells["dgvVariantId"].Value == DBNull.Value ? "0" : item.Cells["dgvExperienceId"].Value));
                            cmd.Parameters.AddWithValue("@MobileId", mblId);
                            cmd.Parameters.AddWithValue("@RamRom", item.Cells["dgvRam_Rom"].Value);
                            cmd.Parameters.AddWithValue("@Price", item.Cells["dgvPrice"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                LoaddgvMobileList();
                Clear();
                MessageBox.Show("Submitted Successfully");
            }
        }

        private void dgvMobileList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMobileList.CurrentRow.Index != -1)
            {
                DataGridViewRow dgvRow = dgvMobileList.CurrentRow;
                intMobileId = Convert.ToInt32(dgvRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViewMobileByMobileId",con);
                    sda.SelectCommand.CommandType= CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@MobileId", intMobileId);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    //--Master---
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtMobileCode.Text = dr["MobileModel"].ToString();
                    txtMobileName.Text = dr["MobileName"].ToString();
                    cmbVersion.SelectedValue = Convert.ToInt32(dr["MobileVersionId"].ToString());
                    dtpLaunchDate.Value = Convert.ToDateTime(dr["LaunchDate"].ToString());
                    if (Convert.ToBoolean(dr["IsStock"].ToString())){
                        chkAvailability.Checked = true;
                    }
                    else
                    {
                        chkAvailability.Checked = false;
                    }
                   if ((dr["Gender"].ToString().Trim())=="Male")
                    {
                        rbtnSmart.Checked = true;
                    }
                    else
                    {
                        rbtnSmart.Checked = false;
                    }
                    if ((dr["MobileType"].ToString().Trim()) == "Button")
                    {
                        rbtnButton.Checked = true;
                    }
                    else
                    {
                        rbtnButton.Checked = false;
                    }
                    if (dr["ImagePath"] == DBNull.Value)
                    {
                        pictureBoxMobile.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
                    }
                    else
                    {
                        string image = dr["ImagePath"].ToString();
                        pictureBoxMobile.Image = new Bitmap(Application.StartupPath + "\\images\\" + dr["ImagePath"].ToString());                 
                        strPreviousImage = dr["ImagePath"].ToString();
                        defaultImage = false;
                    }
                    //--Details---
                    dgvVariant.AutoGenerateColumns = false;
                    dgvVariant.DataSource = ds.Tables[1];
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string image = "";
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViewMobileByMobileId", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@MobileId", intMobileId);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DataRow dr = ds.Tables[0].Rows[0];
                    if (dr["ImagePath"] != DBNull.Value)
                    {
                        image = dr["ImagePath"].ToString();
                        var filename = Application.StartupPath + "\\images\\" + image;
                        if (pictureBoxMobile.Image != null)
                        {
                            pictureBoxMobile.Image.Dispose();
                            pictureBoxMobile.Image = null;
                            System.IO.File.Delete(filename);
                        }

                    }
                    SqlCommand cmd = new SqlCommand("MblExperienceDelete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MobileId", intMobileId);
                    sda.Dispose();
                    cmd.ExecuteNonQuery();
                    LoaddgvMobileList();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
                //File.Delete(filePath);
            }
        }

        private void dgvVariant_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvVariant.CurrentRow;
            if (dgvRow.Cells["dgvVariantId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Master Details", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("VariantDelete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VariantId", dgvRow.Cells["dgvVariantId"].Value);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewAllMobiles", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                List<MobileViewModel> list = new List<MobileViewModel>();
                MobileViewModel mobileVm;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        mobileVm = new MobileViewModel();
                        mobileVm.MobileId = Convert.ToInt32(dt.Rows[i]["MobileId"]);
                        mobileVm.MobileModel = dt.Rows[i]["MobileModel"].ToString();
                        mobileVm.MobileName = dt.Rows[i]["MobileName"].ToString();
                        mobileVm.LaunchDate = Convert.ToDateTime(dt.Rows[i]["LaunchDate"].ToString());
                        mobileVm.MobileType = dt.Rows[i]["MobileType"].ToString();
                        mobileVm.IsStock = Convert.ToBoolean(dt.Rows[i]["IsStock"].ToString());
                        mobileVm.TotalPrice = Convert.ToInt32(dt.Rows[i]["TotalPrice"]);
                        mobileVm.MobileVersionTitle = dt.Rows[i]["MobileVersionTitle"].ToString();
                        mobileVm.ImagePath = Application.StartupPath + "\\images\\" + dt.Rows[i]["ImagePath"].ToString();
                        list.Add(mobileVm);

                    }
                    using (MobileReport report = new MobileReport(list))
                    {
                        report.ShowDialog();
                    }
                }


            }
        }
    }
}
