using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PhongTro
{
    internal class Function
    {
        public void Connect(SqlConnection conn)
        {
            string connect = "Server=LAPTOP-9S1O4HRM\\SQLEXPRESS;Database=QUANLYTRO; Integrated Security = True; Trust Server Certificate=True";
            conn.ConnectionString = connect;

            conn.Open();
        }

        public void LoadComBoBox(string sql, SqlConnection conn, ComboBox combo, string hienThi, string giaTri)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            combo.DataSource = dt;
            combo.DisplayMember = hienThi;
            combo.ValueMember = giaTri;
        }


        public void LoadDataGridView(DataGridView dg, SqlConnection conn, string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            DataSet table = new DataSet();
            adapter.Fill(table, "a");
            dg.DataSource = table;
            dg.DataMember = "a";
        }

        public void LoadContract(DataGridView dataGridView, SqlConnection conn, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            dataGridView.Columns["MaHDT"].HeaderText = "Mã HD";          
            dataGridView.Columns["NGAY_THUE"].HeaderText = "NGÀY THUÊ";  
            dataGridView.Columns["THOI_HAN"].HeaderText = "THỜI HẠN";    
            dataGridView.Columns["NOI_DUNG"].HeaderText = "NỘI DUNG";  
            dataGridView.Columns["KH"].HeaderText = "KHÁCH HÀNG";      
            dataGridView.Columns["TEN PHONG"].HeaderText = "PHÒNG";
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
        }

        public void LoadRoom(DataGridView dataGridView, SqlConnection conn, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            dataGridView.Columns["MaPhong"].HeaderText = "Mã Phòng";          
            dataGridView.Columns["TenPhong"].HeaderText = "TÊN PHÒNG";   
            dataGridView.Columns["GIA"].HeaderText = "GIÁ";     
            dataGridView.Columns["TrangThai"].HeaderText = "TRẠNG THÁI";  
            dataGridView.Columns["TENLOAI"].HeaderText = "LOẠI PHÒNG";
            dataGridView.Columns["GIA"].DefaultCellStyle.Format = "C0";
            dataGridView.Columns["GIA"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
        }


        public void LoadCustomer(DataGridView dataGridView, SqlConnection conn, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();  
            adapter.Fill(dataTable);    
            dataGridView.DataSource = dataTable;

            dataGridView.Columns["MaKH"].HeaderText = "MÃ KHÁCH";         
            dataGridView.Columns["TenKH"].HeaderText = "TÊN KHÁCH";  
            dataGridView.Columns["SoDT"].HeaderText = "ĐIỆN THOẠI";  
            dataGridView.Columns["DiaChi"].HeaderText = "ĐỊA CHỈ";  
            dataGridView.Columns["GioiTinh"].HeaderText = "GIỚI TÍNH";
            dataGridView.Columns["So_cccd"].HeaderText = "CCCD";
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
        }

        public void LoadOrderDetail (DataGridView dataGridView, SqlConnection conn, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();  
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;


            dataGridView.Columns["MaCTHD"].HeaderText = "HÓA ĐƠN";           
            dataGridView.Columns["MaHDT"].HeaderText = "HỢP ĐỒNG";   
            dataGridView.Columns["NgayThang"].HeaderText = "THỜI GIAN";
            dataGridView.Columns["CSD"].HeaderText = "CHỈ SỐ ĐIỆN";
            dataGridView.Columns["CSN"].HeaderText = "CHỈ SỐ NƯỚC";
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
        }
        public void LoadAccount(DataGridView dataGridView, SqlConnection conn, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            dataGridView.Columns["USERNAME"].HeaderText = "TÊN ĐĂNG NHẬP";
            dataGridView.Columns["DISPLAYNAME"].HeaderText = "TÊN HIỂN THỊ";
            dataGridView.Columns["PASSWORD"].HeaderText = "MẬT KHẨU";
            dataGridView.Columns["ROLE"].HeaderText = "VAI TRÒ";
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
        }
    }
}
