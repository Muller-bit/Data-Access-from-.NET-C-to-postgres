using System;
using Npgsql;
namespace data01.Data
{
    public class DBTask
    {
        public long task_id = -1;
        public string taskname="";
        public string supervisor="";
        public string email_supervisor= "";
        public string responsible= "";
        public string email_responsible= "";
        public string created_on="";
        public string deadline="";
        public string first_delivering ="";
        public string first_revising="";
        public int estimate_hours = -1;
        public int effective_hours = -1;
        public string status ="";
        public bool set_from_reader(NpgsqlDataReader r)
        {
            if(r.IsOnRow)
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                            string fname = r.GetName(i);
                            if(fname=="task_id")
                            this.task_id = r.GetInt64(i);
                            else if(fname=="taskname")
                            this.taskname=r.GetString(i);
                            else if(fname =="supervisor")
                            this.supervisor = r.GetString(i);
                            else if(fname=="email_supervisor")
                            this.email_supervisor  =r.GetString(i);
                            else if(fname=="responsible")
                            this.responsible=r.GetString(i);
                            else if(fname== "email_responsible")
                            this.email_responsible = r.GetString(i);
                            else if(fname == "deadline")
                            this.deadline = r.GetString(i);
                }
               return true; 
            }
             return false;
        }
    }
}