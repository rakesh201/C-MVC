using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SimpleMVC.Core
{
    public class CollegeBUS
    {
        private CollegeDAO _collegeDAO;
        public CollegeBUS()
        {
            _collegeDAO  = new CollegeDAO();
        }
        public CollegeVO getCollegeEmailByName(string name)
        {
            CollegeVO collegeVO = new CollegeVO();
            DataTable dataTable = new DataTable();

            dataTable = _collegeDAO.searchByName(name);

            foreach (DataRow dr in dataTable.Rows)
            {
                collegeVO.idCollege = Int32.Parse(dr["t01_id"].ToString());
                collegeVO.collegename = dr["t01_collegename"].ToString();
                collegeVO.physicaladdress = dr["t01_physicaladdress"].ToString();
                collegeVO.email = dr["t01_email"].ToString();
            }
            return collegeVO;
        }

    
        public CollegeVO getCollegeById(string _id)
        {
            CollegeVO collegeVO = new CollegeVO();
            DataTable dataTable = new DataTable();
            dataTable = _collegeDAO.searchById(_id);

            foreach (DataRow dr in dataTable.Rows)
            {
                collegeVO.idCollege = Int32.Parse(dr["t01_id"].ToString());
                collegeVO.collegename = dr["t01_collegename"].ToString();
                collegeVO.physicaladdress = dr["t01_physicaladdress"].ToString();
                collegeVO.email = dr["t01_email"].ToString();
            }
            return collegeVO;
        }
    }
}
