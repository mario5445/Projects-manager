using MySql.Data.MySqlClient;
using System;

namespace ProjectsManager
{
    public class DatagridviewHandler
    {
        private string query = "SELECT p.project_id AS 'id', p.project_name AS 'name', u.user_full_name AS 'teacher', us.user_full_name AS 'student', us.name_of_class AS 'student_class' ,dp.department_name AS 'department', p.project_status AS 'status'" +
                "\r\nFROM projects AS p" +
                "\r\nINNER JOIN users AS u ON p.project_teacher = u.user_id" +
                "\r\nLEFT JOIN (" +
                "\r\n    SELECT usr.user_id, usr.user_full_name, cl.class_name AS name_of_class " +
                "\r\n    FROM users AS usr " +
                "\r\n    LEFT JOIN classes AS cl ON usr.user_class = cl.class_id) " +
                "\r\n    AS us ON p.project_student = us.user_id" +
                "\r\nLEFT JOIN departments AS dp ON p.project_department = dp.department_id";

        public static string defaultQuery { get; private set; }

        public DatagridviewHandler()
        {
            defaultQuery = query;
        }

        #region Methods
        /// <summary>
        /// Gets default reader for mainDatagridview
        /// </summary>
        /// <returns>MySqlDataReader of projects</returns>
        public MySqlDataReader GetDataReaderOfProjects()
        {
            MySqlCommand cmd = new MySqlCommand(defaultQuery, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }  

        #endregion
    }
}
