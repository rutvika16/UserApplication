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
    [Table("AppUsers",Schema="dbo")]
    public partial class AppUser
    {
		#region AppUserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion AppUserId Annotations

        public int AppUserId { get; set; }

		#region FirstName Annotations

        [Required]
        [MaxLength(20)]
		#endregion FirstName Annotations

        public string FirstName { get; set; }

		#region LastName Annotations

        [Required]
        [MaxLength(20)]
		#endregion LastName Annotations

        public string LastName { get; set; }

		#region MobileNumber Annotations

        [Required]
        [MaxLength(15)]
		#endregion MobileNumber Annotations

        public string MobileNumber { get; set; }

		#region EmailId Annotations

        [Required]
        [MaxLength(50)]
		#endregion EmailId Annotations

        public string EmailId { get; set; }

		#region BirthDate Annotations

        [Required]
		#endregion BirthDate Annotations

        public System.DateTime BirthDate { get; set; }

		#region Gender Annotations

        [MaxLength(6)]
		#endregion Gender Annotations

        public string Gender { get; set; }

		#region Password Annotations

        [MaxLength(132)]
		#endregion Password Annotations

        public byte[] Password { get; set; }

		#region Salt Annotations

        [MaxLength(140)]
		#endregion Salt Annotations

        public byte[] Salt { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region UpdatedDateTime Annotations

        [Required]
		#endregion UpdatedDateTime Annotations

        public System.DateTimeOffset UpdatedDateTime { get; set; }

		#region RoleId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("AppRoles","dbo","","RoleId")]
		#endregion RoleId Annotations

        public int RoleId { get; set; }

		#region Status Annotations

        [Required]
		#endregion Status Annotations

        public bool Status { get; set; }

		#region UserName Annotations

        [Required]
        [MaxLength(20)]
		#endregion UserName Annotations

        public string UserName { get; set; }

		#region AppRole Annotations

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(UserApp.Models.Main.AppRole.AppUsers))]
		#endregion AppRole Annotations

        public virtual AppRole AppRole { get; set; }

		#region UserAddresses Annotations

        [InverseProperty("AppUser")]
		#endregion UserAddresses Annotations

        public virtual ICollection<UserAddress> UserAddresses { get; set; }


        public AppUser()
        {
			UserAddresses = new HashSet<UserAddress>();
        }
	}
}