using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MathTrain.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MathTrainUser class
public class MathTrainUser : IdentityUser
{
	//[PersonalData]
	//[Column(TypeName ="nvarchar(100)")]
	//public string Name { get; set; }

	//[PersonalData]
	//[Column(TypeName = "nvarchar(100)")]
	//public string Password { get; set; }

	[PersonalData]
	[Column(TypeName = "int")]
	public int Score { get; set; }
}

