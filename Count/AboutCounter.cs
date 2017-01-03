using System;
using System.Data;
using System.Data.SqlClient;

namespace Count
{
    /// <summary>
    /// 访问统计类
    /// </summary>
    public class AboutCounter : DBclass
    {
        public AboutCounter()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        //获得用户数据//
        public int SelectUserIplocalA(string userip)
        {
            string sql = "Select Count(CountCountry) from Count_Iplocal where '" + userip + "' between CountSTARTIP and CountENDIP";
            return ExecuteCount(sql);
        }
        public DataSet SelectUserIplocalD(string tablename, string userip)
        {
            string sql = "Select CountCOUNTRY,CountIPLOCAL  from Count_Iplocal where '" + userip + "' between CountSTARTIP and CountENDIP";
            return ExecuteSqlDs(sql, tablename);
        }
        public int SelectCountYearA(int CountYearA)
        {
            string sql = "Select Count(CountYear) from Count_Year where CountYear='" + CountYearA + "'";
            return ExecuteCount(sql);
        }
        public int SelectCountMonthC(int CountMonthA)
        {
            string sql = "Select Count(CountMonth) from Count_Month where CountMonth='" + CountMonthA + "'";
            return ExecuteCount(sql);
        }
        public int SelectCountMonthT(int CountMonthA)
        {
            string sql = "Select Count(CountMonth) from Count_Total where CountMonth='" + CountMonthA + "'";
            return ExecuteCount(sql);
        }
        public int AddUserInfor(string CountIpA, string CountLogtimeA, string CountCountryA, string CountLocalA, string CountRefererA, string CountBrowserA, string CountOsA)
        {
            int AddResult = 0;
            string sql = "Insert into Count_Visitor(CountIp,CountLogtime,CountCountry,CountLocal,CountReferer,CountBrowser,CountOs)";
            sql += "values('" + CountIpA + "','" + CountLogtimeA + "','" + CountCountryA + "','" + CountLocalA + "','" + CountRefererA + "','" + CountBrowserA + "','" + CountOsA + "')";
            AddResult = ExecuteSql(sql);
            if (AddResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int AddYear(int CountYearA)
        {
            int AddResult = 0;
            string sql = "Insert into Count_Year(CountYear)";
            sql += "values(" + CountYearA + ")";
            AddResult = ExecuteSql(sql);
            if (AddResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int AddMonth(int CountMonthA)
        {
            int AddResult = 0;
            string sql = "Insert into Count_Month(CountMonth)";
            sql += "values(" + CountMonthA + ")";
            AddResult = ExecuteSql(sql);
            if (AddResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int EditYear(int CountYearA, int CountMA)
        {
            int EditResult = 0;
            string sql = "update Count_Year set CountM" + CountMA + "=CountM" + CountMA + "+1 ";
            sql += " where CountYear=" + CountYearA + "";
            EditResult = ExecuteSql(sql);
            if (EditResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int EditMonth(int CountMonthA, int CountDA)
        {
            int EditResult = 0;
            string sql = "update Count_Month set CountD" + CountDA + "=CountD" + CountDA + "+1 ";
            sql += " where CountMonth=" + CountMonthA + "";
            EditResult = ExecuteSql(sql);
            if (EditResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int SelectCountBOL(string nameA, string nameAA)
        {
            string sql = "Select Count(" + nameA + ") from " + nameA + " where " + nameA + "='" + nameAA + "'";
            return ExecuteCount(sql);
        }
        public int AddBOL(string nameA, string nameAA)
        {
            int AddResult = 0;
            string sql = "Insert into " + nameA + "(" + nameA + ")";
            sql += "values('" + nameAA + "')";
            AddResult = ExecuteSql(sql);
            if (AddResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int EditBOLE(string nameA, string nameAA)
        {
            int EditResult = 0;
            string sql = "update  " + nameA + " set Count_Count=Count_Count+1 where " + nameA + "='" + nameAA + "' ";
            EditResult = ExecuteSql(sql);
            if (EditResult == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //至此结束//
        //后台显示统计信息//
        public DataSet CountMonthList(string tablename, int CountMonthA)
        {
            string sql = "Select * from Count_Month where CountMonth=" + CountMonthA + "";
            return ExecuteSqlDs(sql, tablename);
        }
        public DataSet CountYearList(string tablename, int CountYearA)
        {
            string sql = "Select * from Count_Year where CountYear=" + CountYearA + "";
            return ExecuteSqlDs(sql, tablename);
        }
        public DataSet CountBOLList(string tablename)
        {
            string sql = "Select top 50 * from " + tablename + " order by Count_Count desc";
            return ExecuteSqlDs(sql, tablename);
        }
        public int SelectCountBOL(string nameA)
        {
            string sql = "Select Count(" + nameA + ") from " + nameA + " ";
            return ExecuteCount(sql);
        }
        public int SelectMaxCountBOL(string nameA)
        {
            string sql = "Select Max(Count_Count) from " + nameA + " ";
            return ExecuteCount(sql);
        }
        public DataSet SelectSumCountBOL(string nameA)
        {
            string sql = "Select Sum(Count_Count) as SumCount from " + nameA + " ";
            return ExecuteSqlDs(sql, nameA);
        }
        //访客列表		
        public int CountListCount(string tablename)
        {
            string sql = "Select Count(CountId) From " + tablename + " ";
            return ExecuteCount(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="repeatestr1">开始记录</param>
        /// <param name="repeatestr2">最大记录</param>
        /// <returns></returns>
        public DataSet CountList(string tablename, int repeatestr1, int repeatestr2)
        {
            string sql = "select * From Count_Visitor order by CountId desc";
            return ExecuteSqlDsReapter(sql, repeatestr1, repeatestr2, tablename);
        }
        //至此结束//
        //总计统计Count_Total
        public void upTotal()
        {
            string sql = "Update [Count_Total] set Count_Total = Count_Total + 1 where Count_Name = 'Total'";
            ExecuteSql(sql);
        }
        public object SelectToday(int CountMonthA, int CountDA)
        {
            string sql = "Select [CountD" + CountDA + "] from [Count_Month] where [CountMonth]=" + CountMonthA + " ";
            return ExecuteSql4ValueEx(sql);
        }
        public void upMaxDay(int Count_Day)
        {
            string sql = "Select [Count_Total] from [Count_Total] where Count_Name = 'MaxDay'";
            int No = (int)ExecuteSql4ValueEx(sql);
            if (Count_Day > No)
            {
                sql = "Update [Count_Total] set Count_Total = " + Count_Day + " where Count_Name = 'MaxDay'";
                ExecuteSql(sql);
            }
        }
        //至此结束
    }
}
