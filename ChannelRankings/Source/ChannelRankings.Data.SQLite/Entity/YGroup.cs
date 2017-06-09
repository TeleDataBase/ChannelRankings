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
  public  class YGroup
    {
      [Key]
      public int GroupID { get; set; }
      [MaxLength(64)]
      public string GroupName { get; set; }
      [MaxLength(64)]
      public string GroupType { get; set; }
    }
}
