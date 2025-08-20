using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEE
{
    public string Code { get; set; } = null!;

    public string? Employee2 { get; set; }

    public string? Status { get; set; }

    public string? EmployeeType { get; set; }

    public string? Prefix { get; set; }

    public string? Branch { get; set; }

    public string? TitleEng { get; set; }

    public string? TitleThai { get; set; }

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? Lastname1 { get; set; }

    public string? Lastname2 { get; set; }

    public string? Nickname { get; set; }

    public byte[]? ImgFile { get; set; }

    public string? IDCardNo { get; set; }

    public DateTime? IDIssueDate { get; set; }

    public DateTime? IDExpDate { get; set; }

    public string? IDCardType { get; set; }

    public string? IDCardLocation { get; set; }

    public string? IDCardProvince { get; set; }

    public string? PlaceOfBrith { get; set; }

    public string? BusWay { get; set; }

    public string? BusStation { get; set; }

    public string? SocialNo { get; set; }

    public DateTime? SocialExpDate { get; set; }

    public string? TaxNo { get; set; }

    public string? PassportID { get; set; }

    public DateTime? PassportExpDate { get; set; }

    public string? Department { get; set; }

    public string? Division { get; set; }

    public string? Sectionn { get; set; }

    public string? Positionn { get; set; }

    public string? PhoneNo { get; set; }

    public string? Extension { get; set; }

    public string? FaxNo { get; set; }

    public string? Email { get; set; }

    public string? Job { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartYear { get; set; }

    public int? StartMonth { get; set; }

    public int? StartDay { get; set; }

    public DateTime? PositionDate { get; set; }

    public int? PositionYear { get; set; }

    public int? PositionMonth { get; set; }

    public int? PositionDay { get; set; }

    public string? Probation { get; set; }

    public int? ProbationDayMonth { get; set; }

    public DateTime? ProbationDate { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? DateOfBirthYear { get; set; }

    public int? DateOfBirthMonth { get; set; }

    public int? DateOfBirthDay { get; set; }

    public string? Sex { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public int? TotalChild { get; set; }

    public int? NoofChild { get; set; }

    public int? StudyChild { get; set; }

    public int? TotalRelative { get; set; }

    public decimal? BigBrother { get; set; }

    public decimal? Brother { get; set; }

    public decimal? BigSister { get; set; }

    public decimal? Sister { get; set; }

    public int? TaxPaidBy { get; set; }

    public string? Marital { get; set; }

    public string? Nationality { get; set; }

    public string? MilitaryStatus { get; set; }

    public string? Religion { get; set; }

    public string? Blood { get; set; }

    public string? Origin { get; set; }

    public string? Hobbies { get; set; }

    public decimal? Sport { get; set; }

    public string? Specialist { get; set; }

    public string? Diseases { get; set; }

    public string? TRNFlag { get; set; }

    public DateTime? ResignDate { get; set; }

    public string? ResignReason { get; set; }

    public string? Approve { get; set; }

    public int? AnnualDay { get; set; }

    public int? AnnualHour { get; set; }

    public string? Bank { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountName { get; set; }

    public decimal? CashPercent { get; set; }

    public decimal? BankPercent { get; set; }

    public decimal? CashAmount { get; set; }

    public decimal? BankAmount { get; set; }

    public string? PFNo { get; set; }

    public DateTime? PFDate { get; set; }

    public DateTime? PFDateEnd { get; set; }

    public decimal? PFComper { get; set; }

    public decimal? PFEmpper { get; set; }

    public decimal? PFTotal { get; set; }

    public string? WorkPlan { get; set; }

    public string? District { get; set; }

    public string? Province { get; set; }

    public string? Type { get; set; }

    public string? LateCode { get; set; }

    public string? OTCode { get; set; }

    public string? SpouseNameEng { get; set; }

    public string? SpouseNameThai { get; set; }

    public string? SpouseIDCard { get; set; }

    public DateTime? SpouseBirthDay { get; set; }

    public string? SpouseWorkOffice { get; set; }

    public DateTime? SpouseRegisterDate { get; set; }

    public string? SpouseRegisterLocation { get; set; }

    public string? Occupation { get; set; }

    public string? SpouseTel { get; set; }

    public int? TaxType { get; set; }

    public decimal? Insurance { get; set; }

    public decimal? Interest { get; set; }

    public decimal? InsuranceSelf { get; set; }

    public decimal? InsuranceSpouse { get; set; }

    public decimal? InsuranceFatherSelf { get; set; }

    public decimal? InsuranceMotherSelf { get; set; }

    public decimal? InsuranceFatherSpouse { get; set; }

    public decimal? InsuranceMotherSpouse { get; set; }

    public decimal? Donation { get; set; }

    public decimal? LTF { get; set; }

    public decimal? RMF { get; set; }

    public decimal? Scholarship { get; set; }

    public string? Comment { get; set; }

    public byte? Block { get; set; }

    public byte[]? Image { get; set; }

    public string? ImagePath { get; set; }

    public bool? NotCalculateTime { get; set; }

    public bool? AutoShift { get; set; }

    public bool? AutoShiftOverDay { get; set; }

    public bool? Social { get; set; }

    public bool? FatherUseTax { get; set; }

    public string? IDCardFather { get; set; }

    public bool? MotherUseTax { get; set; }

    public string? IDCardMother { get; set; }

    public bool? FatherSpouseUseTax { get; set; }

    public string? IDCardFatherSpouse { get; set; }

    public bool? MotherSpouseUseTax { get; set; }

    public string? IDCardMotherSpouse { get; set; }

    public string COMID { get; set; } = null!;

    public decimal? InsurancParent { get; set; }

    public DateTime? StandResign { get; set; }

    public int? NotifyResing { get; set; }

    public bool? StatusOvertime { get; set; }

    public bool? StatusProbation { get; set; }

    public int? PFTechEmp { get; set; }

    public int? PFTechCom { get; set; }

    public DateTime? StartDateReg { get; set; }

    public string? DepartmentGroup { get; set; }

    public string? RegisterTech { get; set; }

    public string? RegisterTechNo { get; set; }

    public string? LeaveRequestGroup { get; set; }

    public string? LeaveReviewGroup { get; set; }

    public string? LeaveApproveGroup { get; set; }

    public string? LeaveRecheckGroup { get; set; }

    public string? OvertimeRequestGroup { get; set; }

    public string? OvertimeReviewGroup { get; set; }

    public string? OvertimeApproveGroup { get; set; }

    public string? OvertimeRecheckGroup { get; set; }

    public string? EmployeeGroup { get; set; }

    public int? ProvationAlertDate { get; set; }

    public string? RefRecruit { get; set; }

    public string? Hopital { get; set; }

    public string? MobilePhone { get; set; }

    public string? DocWorkApprove { get; set; }

    public DateTime? DocDateWorkApprove { get; set; }

    public DateTime? DocWorkApproveExpireDate { get; set; }

    public string? ActForPosition { get; set; }

    public DateTime? ActForDate { get; set; }

    public string? Membership { get; set; }

    public DateTime? MembershipDate { get; set; }

    public DateTime? MembershipExpireDate { get; set; }

    public string? UnitRef { get; set; }

    public DateTime? EnrollDate { get; set; }

    public string? DriverLicence { get; set; }

    public DateTime? DriverLicenceExpire { get; set; }

    public string? Manager { get; set; }

    public string? CompanyGroupID { get; set; }

    public string? LocationID { get; set; }

    public string? BusinessLineID { get; set; }

    public string? JobBandID { get; set; }

    public string? JobLevelID { get; set; }

    public string? CareerPathID { get; set; }

    public string? WelderID { get; set; }

    public string? ACardID { get; set; }

    public string? CostPathID { get; set; }

    public string? EvaluationLevelID { get; set; }

    public string? MachineControlID { get; set; }

    public string? SpecialEmployeeType { get; set; }

    public string? JobPath { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? FartherNameSpouse { get; set; }

    public string? MotherNameSpouse { get; set; }

    public string? Source { get; set; }

    public string? ReasonExpireSSO { get; set; }

    public string? EmployeeHireGroup { get; set; }

    public string? Zone { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public decimal? WorkTimeHour { get; set; }

    public bool? FlexableTime { get; set; }

    public string? Employee3 { get; set; }

    public string? Costcenter { get; set; }

    public string? ResignComment { get; set; }

    public bool? Allowance { get; set; }

    public string? LeavePosition { get; set; }

    public string? InsuranceEnc { get; set; }

    public bool? PFManual { get; set; }

    public decimal? travelTax { get; set; }

    public decimal? pensionTax { get; set; }

    public decimal? deductionsTax1 { get; set; }

    public decimal? deductionsTax2 { get; set; }

    public decimal? deductionsTax3 { get; set; }

    public decimal? deductionsTax4 { get; set; }

    public decimal? deductionsTax5 { get; set; }

    public string? ProvidentfundType { get; set; }

    public DateTime? ResignSSO { get; set; }

    public string? TimeAllowanceGroup { get; set; }

    public decimal? FirstHouse { get; set; }

    public bool? OTbuffetCheck { get; set; }

    public string? OrderChildren { get; set; }

    public bool? PFComAuto { get; set; }

    public bool? PFEmpAuto { get; set; }

    public int? Child2561 { get; set; }

    public string? AssetGroup { get; set; }

    public decimal? InsuranceHealth { get; set; }

    public decimal? SSF { get; set; }

    public decimal? SSFS { get; set; }

    public decimal? PrenatalCare { get; set; }

    public decimal? PoliticalDonation { get; set; }

    public decimal? SocialEnterprice { get; set; }

    public decimal? ShopDeeMoneyback { get; set; }

    public decimal? ThaiESG { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual BUSSTATION? BUSSTATION { get; set; }

    public virtual BUSWAY? BUSWAY { get; set; }

    public virtual BANK? BankNavigation { get; set; }

    public virtual BLOOD? BloodNavigation { get; set; }

    public virtual COMPANY COM { get; set; } = null!;

    public virtual COMPANYGROUP? CompanyGroup { get; set; }

    public virtual COSTPATH? CostPath { get; set; }

    public virtual DEPARTMENT? DepartmentNavigation { get; set; }

    public virtual DIVISION? DivisionNavigation { get; set; }

    public virtual EMPLOYEEGROUP? EMPLOYEEGROUP { get; set; }

    public virtual EMPLOYEETYPE? EmployeeTypeNavigation { get; set; }

    public virtual HOSPITAL? HopitalNavigation { get; set; }

    public virtual JOBBAND? JobBand { get; set; }

    public virtual JOBLEVEL? JobLevel { get; set; }

    public virtual JOB? JobNavigation { get; set; }

    public virtual JOBPATH? JobPathNavigation { get; set; }

    public virtual LOCATION? Location { get; set; }

    public virtual MACHINECONTROL? MachineControl { get; set; }

    public virtual MARITALSTATUS? MaritalNavigation { get; set; }

    public virtual MEMBERSHIP? MembershipNavigation { get; set; }

    public virtual MILITARYSTATUS? MilitaryStatusNavigation { get; set; }

    public virtual NATIONALITY? NationalityNavigation { get; set; }

    public virtual OCCUPATION? OccupationNavigation { get; set; }

    public virtual POSITION? PositionnNavigation { get; set; }

    public virtual RATE? RATE { get; set; }

    public virtual RELIGION? ReligionNavigation { get; set; }

    public virtual COST? SpecialistNavigation { get; set; }

    public virtual UNITREF? UnitRefNavigation { get; set; }

    public virtual WORKPLAN? WORKPLAN { get; set; }

    public virtual WELDER? Welder { get; set; }

    public virtual ZONE? ZoneNavigation { get; set; }
}
