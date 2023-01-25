using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    [Table("competitors")]
    class Competitor
    {
        [Key, Column("id")]
        public int ID { get; set; }
                
        [Index("Index_EntryNumber", IsUnique = true), Column("entry_name")]
        public string EntryNumber { get; set; }
        
        [Column("name")]
        public string Name { get; set; }

        [Column("passport_name")]
        public string PassportName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("reg_phone")]
        public String RegPhone { get; set; }

        [Column("updated_time")]
        public DateTime UpdatedTime { get; set; }

        [Column("check_in")]
        public Boolean CheckIn { get; set; }

        [Index("Index_DrawingId", IsUnique = true), Column("drawing_id")]
        public string DrawingId { get; set; }

        [Column("teacher_name")]
        public string TeacherName { get; set; }

        [Column("teacher_phone")]
        public string TeacherPhone { get; set; }

        [Column("reg_teacher_phone")]
        public string RegTeacherPhone { get; set; }

        [Column("rank")]
        public string Rank { get; set; }

        [Index("Index_rankId"), Column("rank_id")]
        public int RankId { get; set; }

        [Column("group")]
        public string Group { get; set; }

        [Index("Index_groupId"), Column("group_id")]
        public int GroupId { get; set; }

        [Index("Index_CompetitionType"), Column("competition_type")]
        public int CompetitionType { get; set; }


        [Column("gender")]

        public string Gender { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("school")]
        public string School { get; set; }

        [Column("updated_ip")]
        public string UpdatedIp { get; set; }


    }

}
