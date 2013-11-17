using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace GroceryAssistant.Models
{
    public class ListsContext : DbContext
    {
        public ListsContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ListModel> Lists { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
    }

    [Table("List")]
    public class ListModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ListID { get; set; }
        public string ListName { get; set; }
        [ForeignKey("UserProfile")]
        public virtual UserProfile User { get; set; }
    }

    [Table("ListItem")]
    public class ListItem
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ListItemID { get; set; }
        public string ItemName { get; set; }
        [ForeignKey("List")]
        public virtual ListModel ListID { get; set; }
    }
}