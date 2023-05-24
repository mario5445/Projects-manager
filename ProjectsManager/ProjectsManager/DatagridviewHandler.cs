using MySql.Data.MySqlClient;
using System;
using System.Runtime.CompilerServices;

namespace ProjectsManager
{
    public class DatagridviewHandler
    {
        #region Fields
        private static string query = "SELECT p.project_id AS 'id', p.project_name AS 'name', u.user_full_name AS 'teacher', us.user_full_name AS 'student', us.name_of_class AS 'student_class' ,dp.department_name AS 'department', p.project_status AS 'status'" +
                "\r\nFROM projects AS p" +
                "\r\nINNER JOIN users AS u ON p.project_teacher = u.user_id" +
                "\r\nLEFT JOIN (" +
                "\r\n    SELECT usr.user_id, usr.user_full_name, cl.class_name AS name_of_class " +
                "\r\n    FROM users AS usr " +
                "\r\n    LEFT JOIN classes AS cl ON usr.user_class = cl.class_id) " +
                "\r\n    AS us ON p.project_student = us.user_id" +
                "\r\nLEFT JOIN departments AS dp ON p.project_department = dp.department_id ";

        private static string userQuery = "SELECT u.user_id AS 'id', u.user_full_name AS 'name', cls.class_name AS 'class_name', u.user_role AS 'role'" +
            "\r\nFROM users AS u" +
            "\r\nLEFT JOIN classes AS cls ON u.user_class = cls.class_id" +
            "\r\nWHERE u.user_role != 'Admin' ";
        #endregion

        #region Properties

        public static string defaultQuery { get => query; private set => query = value; }
        public static string defaultUserQuery { get => userQuery; private set => userQuery = value; }

        #endregion

        #region Constructor
        public DatagridviewHandler()
        {

        }
        #endregion

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

        public MySqlDataReader GetDataReaderOfUsers()
        {
            MySqlCommand cmd = new MySqlCommand(defaultUserQuery, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader GetDataReaderForUserProjects(int user_id)
        {
            MySqlCommand cmd = new MySqlCommand(query + $" WHERE u.user_id = {user_id}", DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader GetDataReaderForClasses()
        {
            string query = "SELECT * FROM classes ORDER BY class_id ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader GetDataReaderForDepartments()
        {
            string query = "SELECT * FROM departments ORDER BY department_id ASC";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        #endregion
    }
}
