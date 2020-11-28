# Workforce.Model.Employee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Title** | **string** |  | [optional] 
**FirstName** | **string** |  | 
**LastName** | **string** |  | 
**DateOfBirth** | **DateTime?** |  | [optional] 
**Gender** | **string** |  | [optional] 
**NationalityId** | **Guid?** |  | [optional] 
**EmploymentTypeId** | **Guid?** |  | [optional] 
**NationalInsuranceNumber** | **string** |  | [optional] 
**NoticePeriodId** | **Guid?** |  | [optional] 
**RecruitmentDetails** | **string** |  | [optional] 
**RecruitmentCost** | **double** |  | 
**ProbationEndDate** | **DateTime?** |  | [optional] 
**WorkDays** | **int** |  | [optional] 
**BankName** | **string** |  | [optional] 
**BankSortCode** | **string** |  | [optional] 
**BankAccountNo** | **string** |  | [optional] 
**BankNotes** | **string** |  | [optional] 
**IsPensionOptedIn** | **bool** |  | [optional] 
**PensionStartDate** | **DateTime?** |  | [optional] 
**TaxCode** | **string** |  | [optional] 
**Salaries** | [**List&lt;Salary&gt;**](Salary.md) |  | [optional] 
**Communications** | [**List&lt;EmployeeCommunicationXref&gt;**](EmployeeCommunicationXref.md) |  | [optional] 
**WorkTimes** | [**List&lt;EmployeeWorkTime&gt;**](EmployeeWorkTime.md) |  | [optional] 
**Contributions** | [**List&lt;PensionContribution&gt;**](PensionContribution.md) |  | [optional] 
**Addresses** | [**List&lt;EmployeeAddressXref&gt;**](EmployeeAddressXref.md) |  | [optional] 
**NextOfKinTitle** | **string** |  | [optional] 
**NextOfKinFirstName** | **string** |  | [optional] 
**NextOfKinLastName** | **string** |  | [optional] 
**NextOfKinOtherNames** | **string** |  | [optional] 
**NextOfKinGender** | **string** |  | [optional] 
**NextOfKinDateOfBirth** | **DateTime?** |  | [optional] 
**NextOfKinAddressId** | **Guid?** |  | [optional] 
**NextOfKinAddress** | [**Address**](Address.md) |  | [optional] 
**ManagerId** | **Guid?** |  | [optional] 
**Manager** | [**Employee**](Employee.md) |  | [optional] 
**DepartmentId** | **Guid?** |  | [optional] 
**Department** | [**Department**](Department.md) |  | [optional] 
**BranchId** | **Guid?** |  | [optional] 
**Branch** | [**Branch**](Branch.md) |  | [optional] 
**JobRoleId** | **Guid?** |  | [optional] 
**JobRole** | [**JobRole**](JobRole.md) |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**LeftDate** | **DateTime?** |  | [optional] 
**Photo** | [**EmployeePhoto**](EmployeePhoto.md) |  | [optional] 
**PhotoId** | **Guid?** |  | [optional] 
**DisplayName** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

