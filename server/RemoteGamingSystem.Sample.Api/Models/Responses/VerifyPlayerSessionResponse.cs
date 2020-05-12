using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
  public class VerifyPlayerSessionResponse
  {

    [Required]
    [StringLength(ApplicationConstants.SecureToken)]
    public string SecureToken { get; set; }

    [StringLength(ApplicationConstants.TerminalId)]
    public string TerminalId { get; set; }

    [StringLength(ApplicationConstants.AffiliateId)]
    public string AffiliateId { get; set; }
   
    [Required]
    [StringLength(ApplicationConstants.JurisdictionCode)]
    public string JurisdictionCode { get; set; }

    [Required]
    [StringLength(ApplicationConstants.Nickname)]
    public string NickName { get; set; }
    
    [StringLength(ApplicationConstants.SegmentId)]
    public string SegmentId { get; set; }

    [StringLength(ApplicationConstants.NamePart)]
    public string FirstName { get; set; }

    [StringLength(ApplicationConstants.NamePart)]
    public string LastName1 { get; set; }

    [StringLength(ApplicationConstants.NamePart)]
    public string LastName2 { get; set; }

    [StringLength(ApplicationConstants.NamePart)]
    public string PreferredName { get; set; }

    [StringLength(ApplicationConstants.Date)]
    public string BirthDate { get; set; }

   
    //public GenderTypes? genderType { get; set; }

   
    //public AccountBalance accountBalance { get; set; }
  }
}
