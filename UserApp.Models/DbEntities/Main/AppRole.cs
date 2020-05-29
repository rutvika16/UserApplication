using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using UserApp.Models.Enums.Main;
using UserApp.BoundedContext.SqlContext;
namespace UserApp.Models.Main
{
    [Table("AppRoles",Schema="dbo")]
    public partial class AppRole
    {
		#region RoleId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion RoleId Annotations

        public int RoleId { get; set; }

		#region RoleName Annotations

        [Required]
        [MaxLength(20)]
		#endregion RoleName Annotations

        public string RoleName { get; set; }

		#region AppUsers Annotations

        [InverseProperty("AppRole")]
		#endregion AppUsers Annotations

        public virtual ICollection<AppUser> AppUsers { get; set; }


        public AppRole()
        {
			AppUsers = new HashSet<AppUser>();
        }
	}
}