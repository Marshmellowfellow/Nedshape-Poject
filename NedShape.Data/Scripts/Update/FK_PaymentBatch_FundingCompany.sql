use DAPRS
go

alter table PaymentBatch
add constraint FK_PaymentBatch_FundingCompany foreign key ( FundingCompanyId ) references fundingcompany(id)