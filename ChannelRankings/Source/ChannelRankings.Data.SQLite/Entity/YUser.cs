using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 作者：音樂咖啡
/// 联系方式：QQ 136463644
/// </summary>
namespace Sqlitecodefirst.Entity
{
    public class YUser
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(64)]
        public string UserName { get; set; }
        [MaxLength(8)]
        public string UserSex { get; set; }
        [MaxLength(64)]
        public string NickName { get; set; }

        //public bool Active { get; set; }
    }
}
