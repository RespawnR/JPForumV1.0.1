using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SQLHelper
    {
        private static readonly string connStr = Configurations.connectionString;
        public static DataTable GetDataTable(string sql, CommandType type, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))//创建连接对象
            {
                //创建适配器对象
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    if (paras != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(paras);//添加参数
                    }
                    adapter.SelectCommand.CommandType = type;
                    DataTable dt = new DataTable();//构造数据表用于接收查询结果                   
                    adapter.Fill(dt);//执行结果，fill方法内部自动打开链接，不需要conn.open();   
                    adapter.SelectCommand.Parameters.Clear();//清空集合
                    return dt; //返回结果集       
                }
            }
        }

        public static int ExcuteNonQuery(string sql, CommandType type, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))//创建连接对象
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) //创建Command连接对象
                {
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);//添加参数
                    }
                    cmd.CommandType = type;
                    conn.Open();//打开链接 
                    int n = cmd.ExecuteNonQuery(); //执行命令并返回受影响的行数  
                    cmd.Parameters.Clear();
                    return n;
                }

            }
        }



        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))//创建连接对象
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn)) //创建Command连接对象
                {
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);//添加参数
                    }
                    cmd.CommandType = type;
                    conn.Open();//打开链接                    
                    return cmd.ExecuteScalar(); ;
                }

            }
        }

    }
}
