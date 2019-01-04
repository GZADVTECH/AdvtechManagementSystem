using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvtechManagementSystem
{
    public partial class frmUsermanage : Form
    {
        private DataTable dt = UserinfoOperate.selectUserinfo();//所有用户信息
        private Timer time = new Timer();
        int num = 1;
        public frmUsermanage()
        {
            InitializeComponent();
            time.Interval = 1000;
            time.Tick += new EventHandler(TimerMessage);
        }
        /// <summary>
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUsermanage_Load(object sender, EventArgs e)
        {
            if(cbbSection.Items.Count!=0)cbbSection.SelectedIndex = 0;
            if (cbbJob.Items.Count != 0) cbbJob.SelectedIndex = 0;
            if (cbbLevel.Items.Count != 0) cbbLevel.SelectedIndex = 0;
            //获取所有用户信息
            lbUser.Items.Clear();
            if (dt.Rows.Count == 0)
            {
                lbUser.Items.Add("暂无成员");
                tsslStatus.Text = "所有用户信息加载完成。";
                time.Start();
                return;
            }
            lbUser.DisplayMember = "username";
            lbUser.ValueMember = "userid";
            lbUser.DataSource = dt;

            tsslStatus.Text = "所有用户信息加载完成。";
            time.Start();
        }
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            string selecttext = tstText.Text;//查询内容
            lbUser.DataSource = null;
            lbUser.Items.Clear();
            DataTable dtSelect;
            if (string.IsNullOrEmpty(selecttext))
                dtSelect = UserinfoOperate.selectUserinfo();
            else
                dtSelect = UserinfoOperate.selectUserinfo(selecttext);
            if (dtSelect.Rows.Count == 0)
            {
                lbUser.Items.Add("暂无成员");
                tsslStatus.Text = "查询内容加载完成。";
                time.Start();
                return;
            }
            lbUser.DisplayMember = "username";
            lbUser.ValueMember = "userid";
            lbUser.DataSource = dtSelect;
            tsslStatus.Text = "查询内容加载完成。";
            time.Start();
        }
        /// <summary>
        /// 选择值改变时改变其内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            object value = lb.SelectedValue;//获取选中的值
            if (value == null)
            {
                rtbUser.Text = "暂无详细信息";
                return;
            }
            DataRow dtc = dt.Rows[lb.SelectedIndex];
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("用户编号：" + dtc["userid"].ToString());
            sb.AppendLine("用户姓名：" + dtc["username"].ToString());
            sb.AppendLine("性别：" + (Convert.ToBoolean(dtc["usergender"]) == false ? "男" : "女"));
            sb.AppendLine("出生日期：" + (dtc["userbirth"] == null ? "" : Convert.ToDateTime(dtc["userbirth"]).ToShortDateString()));
            sb.AppendLine("所属部门：" + (dtc["userdepart"] == null ? "" : dtc["userdepart"].ToString()));
            sb.AppendLine("职务：" + (dtc["userpost"] == null ? "" : dtc["userpost"].ToString()));
            sb.AppendLine("联系方式：" + (dtc["usercontact"] == null ? "" : dtc["usercontact"].ToString()));
            sb.AppendLine("联系地址：" + (dtc["useraddress"] == null ? "" : dtc["useraddress"].ToString()));
            sb.AppendLine("备注：" + (dtc["userremark"] == null ? "" : dtc["userremark"].ToString()));
            sb.AppendLine("权限：" + (dtc["userpower"] == null ? "无权限" : Convert.ToInt32(dtc["userpower"]) == 1 ? "最高管理" :
                Convert.ToInt32(dtc["userpower"]) == 2 ? "仓库管理" : Convert.ToInt32(dtc["userpower"]) == 3 ? "采购管理" :
                Convert.ToInt32(dtc["userpower"]) == 4 ? "行政管理" : Convert.ToInt32(dtc["userpower"]) == 5 ? "技术管理" :
                Convert.ToInt32(dtc["userpower"]) == 6 ? "售后管理" : Convert.ToInt32(dtc["userpower"]) == 7 ? "客服管理" : "其他权限"));
            rtbUser.Text = sb.ToString();
        }
        /// <summary>
        /// 为活动控件时内容为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstText_Enter(object sender, EventArgs e)
        {
            ToolStripTextBox tst = (ToolStripTextBox)sender;
            tst.Text = string.Empty;
        }
        /// <summary>
        /// 初始化（保留用户名，其余的为空）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btninitialize_Click(object sender, EventArgs e)
        {
            if (lbUser.SelectedValue == null)
            {
                MessageBox.Show("请选择需要初始化的用户。", "系统提示");
                return;
            }
            if (MessageBox.Show("是否初始化？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataTable dtinitial = UserinfoOperate.initializeUserinfo(Convert.ToInt32(lbUser.SelectedValue));
                    if (dtinitial.HasErrors)
                    {
                        Errorinfo.errorPost("用户初始化中失败");
                        tsslStatus.Text = "初始化失败，已经反馈服务器，请稍候再试！";
                        time.Start();
                        return;
                    }
                    tsslStatus.Text = "初始化成功。";
                    time.Start();

                    lbUser.DisplayMember = "username";
                    lbUser.ValueMember = "userid";
                    dt = UserinfoOperate.selectUserinfo();
                    lbUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Errorinfo.errorPost("用户初始化中出现问题，问题如下：" + ex.Message);
                    tsslStatus.Text = "初始化失败，已经反馈服务器，请稍候再试！";
                    time.Start();
                    return;
                }
            }
        }
        /// <summary>
        /// 设置倒计时显示
        /// </summary>
        /// <param name="text"></param>
        private void TimerMessage(object sender, EventArgs e)
        {
            num++;
            if (num >= 3)
            {
                num = 0;
                time.Enabled = false;
                tsslStatus.Text = string.Empty;
            }
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateType.NullOrEmptyOfString(txtUsername.Text.Trim(), "用户名")) return;
            if (ValidateType.NullOrEmptyOfString(cbbSection.Text, "部门")) return;
            if (ValidateType.NullOrEmptyOfString(cbbJob.Text, "职务")) return;
            if (MessageBox.Show("是否添加？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //查询是否有相同的用户名
                foreach (DataRowView item in lbUser.Items)
                {
                    if (txtUsername.Text.Trim()==item.Row["username"].ToString())
                    {
                        if (MessageBox.Show("该用户名已存在，是否进行修改？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            btnChange_Click(sender, e);
                        }
                        return;
                    }
                }
                try
                {
                    bool gender = rdbBoy.Checked ? false : true;
                    int level = cbbLevel.Text == "最高管理" ? 1 : cbbLevel.Text == "仓库管理" ? 2 :
                        cbbLevel.Text == "采购管理" ? 3 : cbbLevel.Text == "行政管理" ? 4 :
                        cbbLevel.Text == "技术管理" ? 5 : cbbLevel.Text == "售后管理" ? 6 :
                        cbbLevel.Text == "客服管理" ? 7 : 0;

                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("username", txtUsername.Text);
                    data.Add("usergender", gender);
                    data.Add("userbirth", dtpBirth.Value.ToShortDateString());
                    data.Add("userdepart", cbbSection.Text);
                    data.Add("userpost", cbbJob.Text);
                    data.Add("usercontact", string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text);
                    data.Add("useraddress", string.IsNullOrEmpty(rtbAddress.Text) ? "" : rtbAddress.Text);
                    data.Add("userremark", string.IsNullOrEmpty(rtbRemark.Text) ? "" : rtbRemark.Text);
                    data.Add("userpower", level);
                    DataTable dtinsert = UserinfoOperate.insertUserinfo(data);
                    if (dtinsert.HasErrors)
                    {
                        Errorinfo.errorPost("用户添加中失败");
                        tsslStatus.Text = "添加失败，已经反馈服务器，请稍候再试！";
                        time.Start();
                        return;
                    }

                    tsslStatus.Text = "添加成功。";
                    time.Start();

                    //清空内部信息
                    txtUsername.Text = string.Empty;
                    rdbBoy.Checked = true;
                    dtpBirth.Value = DateTime.Now;
                    cbbSection.SelectedIndex = 1;
                    cbbJob.SelectedIndex = 1;
                    txtPhone.Text = string.Empty;
                    cbbLevel.SelectedIndex = 1;
                    rtbAddress.Text = string.Empty;
                    rtbRemark.Text = string.Empty;


                    lbUser.DisplayMember = "username";
                    lbUser.ValueMember = "userid";
                    dt=UserinfoOperate.selectUserinfo() ;
                    lbUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Errorinfo.errorPost("用户添加中出现问题，问题如下：" + ex.Message);
                    tsslStatus.Text = "添加失败，已经反馈服务器，请稍候再试！";
                    time.Start();
                    return;
                }
            }
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (ValidateType.NullOrEmptyOfString(txtUsername.Text.Trim(), "用户名")) return;
            if (ValidateType.NullOrEmptyOfString(cbbSection.Text, "部门")) return;
            if (ValidateType.NullOrEmptyOfString(cbbJob.Text, "职务")) return;
            if (MessageBox.Show("是否确定修改？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    string id = "";
                    bool gender = rdbBoy.Checked ? false : true;
                    int level = cbbLevel.Text == "最高管理" ? 1 : cbbLevel.Text == "仓库管理" ? 2 :
                        cbbLevel.Text == "采购管理" ? 3 : cbbLevel.Text == "行政管理" ? 4 :
                        cbbLevel.Text == "技术管理" ? 5 : cbbLevel.Text == "售后管理" ? 6 :
                        cbbLevel.Text == "客服管理" ? 7 : 0;
                    foreach (DataRowView item in lbUser.Items)
                    {
                        if (txtUsername.Text.Trim() == item.Row["username"].ToString())
                        {
                            id = item.Row["userid"].ToString();
                            break;
                        }
                    }
                    
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("userid", id);
                    data.Add("username", txtUsername.Text);
                    data.Add("usergender", gender);
                    data.Add("userbirth", dtpBirth.Value.ToShortDateString());
                    data.Add("userdepart", cbbSection.Text);
                    data.Add("userpost", cbbJob.Text);
                    data.Add("usercontact", string.IsNullOrEmpty(txtPhone.Text) ? "" : txtPhone.Text);
                    data.Add("useraddress", string.IsNullOrEmpty(rtbAddress.Text) ? "" : rtbAddress.Text);
                    data.Add("userremark", string.IsNullOrEmpty(rtbRemark.Text) ? "" : rtbRemark.Text);
                    data.Add("userpower", level);
                    DataTable dtinsert = UserinfoOperate.updateUserinfo(data);
                    if (dtinsert.HasErrors)
                    {
                        Errorinfo.errorPost("用户修改中失败");
                        tsslStatus.Text = "修改失败，已经反馈服务器，请稍候再试！";
                        time.Start();
                        return;
                    }

                    tsslStatus.Text = "修改成功。";
                    time.Start();

                    //清空内部信息
                    txtUsername.Text = string.Empty;
                    rdbBoy.Checked = true;
                    dtpBirth.Value = DateTime.Now;
                    cbbSection.SelectedIndex = 1;
                    cbbJob.SelectedIndex = 1;
                    txtPhone.Text = string.Empty;
                    cbbLevel.SelectedIndex = 1;
                    rtbAddress.Text = string.Empty;
                    rtbRemark.Text = string.Empty;

                    lbUser.DisplayMember = "username";
                    lbUser.ValueMember = "userid";
                    dt = UserinfoOperate.selectUserinfo();
                    lbUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Errorinfo.errorPost("用户修改中出现问题，问题如下：" + ex.Message);
                    tsslStatus.Text = "修改失败，已经反馈服务器，请稍候再试！";
                    time.Start();
                    return;
                }
            }
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定删除？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    object id = lbUser.SelectedValue;//获取ID

                    DataTable dtinsert = UserinfoOperate.deleteUserinfo(id);
                    if (dtinsert.HasErrors)
                    {
                        Errorinfo.errorPost("用户删除中失败");
                        tsslStatus.Text = "删除失败，已经反馈服务器，请稍候再试！";
                        time.Start();
                        return;
                    }

                    tsslStatus.Text = "删除成功。";
                    time.Start();

                    lbUser.DisplayMember = "username";
                    lbUser.ValueMember = "userid";
                    dt = UserinfoOperate.selectUserinfo();
                    lbUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Errorinfo.errorPost("用户删除中出现问题，问题如下：" + ex.Message);
                    tsslStatus.Text = "删除失败，已经反馈服务器，请稍候再试！";
                    time.Start();
                    return;
                }
            }
        }
        /// <summary>
        /// 双击用户信息呈现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUser_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            object value = lb.SelectedValue;//获取选中的值
            if (value == null)
            {
                tsslStatus.Text = "暂无详细信息";
                time.Start();
                return;
            }
            DataRow dtc = dt.Rows[lb.SelectedIndex];
            txtUsername.Text = dtc["username"].ToString();
            if (Convert.ToBoolean(dtc["usergender"]) == false) rdbBoy.Checked=true; else rdbGirl.Checked=true;
            dtpBirth.Value= Convert.ToDateTime(dtc["userbirth"]);
            cbbSection.Text = dtc["userdepart"].ToString();
            cbbJob.Text = dtc["userpost"].ToString();
            txtPhone.Text=dtc["usercontact"].ToString();
            rtbAddress.Text = dtc["useraddress"].ToString();
            rtbRemark.Text = dtc["userremark"].ToString();
            cbbLevel.Text= (dtc["userpower"] == null ? "无权限" : Convert.ToInt32(dtc["userpower"]) == 1 ? "最高管理" :
                Convert.ToInt32(dtc["userpower"]) == 2 ? "仓库管理" : Convert.ToInt32(dtc["userpower"]) == 3 ? "采购管理" :
                Convert.ToInt32(dtc["userpower"]) == 4 ? "行政管理" : Convert.ToInt32(dtc["userpower"]) == 5 ? "技术管理" :
                Convert.ToInt32(dtc["userpower"]) == 6 ? "售后管理" : Convert.ToInt32(dtc["userpower"]) == 7 ? "客服管理" : "其他权限");
        }
        /// <summary>
        /// 按下回车进行查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tsbSelect_Click(sender, e);
            }
        }
    }
}