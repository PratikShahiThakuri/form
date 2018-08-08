using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SanimaForm.Models
{
    public class CreditCheckList_General
    {
        [Display(Name ="Duly filled up and signed off Loan application has been obtained for Fresh/renewal/enhancement of credit.(Please choose as applicable)")]
        public SanimaBank.Enums.Remarks DulyFilledUpAndSignedOff { get; set; }
        [Display(Name ="Copies of citizenship certificate , recent photograph, personal net-worth, family tree of Borrowers/ Guarantors obtained")]
        public SanimaBank.Enums.Remarks CopiesOfCitizenshipCertificate { get; set; }
        [Display(Name ="Borrower and Guarantor are not featured in the CICL's Blacklist, Checked and Confirmed.")]
        public SanimaBank.Enums.Remarks BorrowerAndGuarantor { get; set; }
        [Display(Name ="All sister concern /related parties availing credit facilities under Single Ibligor as per NRB Directives are reported under One group.")]
        public SanimaBank.Enums.Remarks AllSisterConcern { get; set; }
        [Display(Name ="Proposal doesnot fall in the (restricted area) as stated in Credit Policy of the Bank")]
        public SanimaBank.Enums.Remarks ProposalDoesnotFall { get; set; }
        [Display(Name ="Standard format of the CM of the Bank has not been tampered with.")]
        public SanimaBank.Enums.Remarks StandardFormatOfTheCM { get; set; }
        [Display(Name ="Credit approval terms of credit chain / approving authority , if any terms, conditions and convenants stipulated in the previously approved CM have been fully compiled with.")]
        public SanimaBank.Enums.Remarks CreditApprovalterm { get; set; }
        [Display(Name ="Pricing are withing the regulatory guidelines.(ie deviation in interest rate is not more than 1% from the published band and not more than 0.25% in fees/charged from the STC of the bank).")]
        public SanimaBank.Enums.Remarks PriceingAreWithinTheRegulatoryGuidelines { get; set; }
        [Display(Name ="All fees & charges as per the previously approved CM have been fully recovered except as waived by the appropriate CAD holder for the credit.")]
        public SanimaBank.Enums.Remarks AllFeesAndCharged { get; set; }
        [Display(Name ="All Internal & External, Statutory audit comments, made in the past 12 months have been satisfactorily resolved/addressed. if not, explicitly explained in the CM.")]
        public SanimaBank.Enums.Remarks AllInternalAndExternal { get; set; }
        [Display(Name ="All copy documents received from the Borrower/Guarantors have been verified/certified with the originals")]
        public SanimaBank.Enums.Remarks AllCopyDocuments { get; set; }
        [Display(Name ="Collateral owner is not insane and minor and competent enough to enter into the contract.")]
        public SanimaBank.Enums.Remarks CollateralOwnerIsnotInsane { get; set; }
        [Display(Name ="*All security documents as per previously approved terms are intact and in order. Security Documents reviewed on....")]
        public SanimaBank.Enums.Remarks AllSecurityDocumentAsPerviouslyApproved { get; set; }
        [Display(Name ="There is no change in security vis-a-vis previous CM. In case any such change was done in between the review period the same has been dully approved by the respective CAD holder and the same is specified in the security appendix of the CM. Else , any deviation is specified in the Deviation section of the CM.")]
        public SanimaBank.Enums.Remarks ThereIsNoChangeInSecurity { get; set; }
        [Display(Name ="Mapping code mentioned in the CM are correct and as per the regulatory and Bank's internal guidelines")]
        public SanimaBank.Enums.Remarks MappingCodeMentioned { get; set; }
        [Display(Name ="If total borrowing of the borrower/group is NPR 10M and above , PAN certificate of the borrower(s) obtained.")]
        public SanimaBank.Enums.Remarks IfTotalBorrowingofBorrower { get; set; }
    }
}