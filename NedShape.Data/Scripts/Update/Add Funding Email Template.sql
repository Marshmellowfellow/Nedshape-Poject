use DAPRS
go

alter table MailChimpIntegration
add  ChimpTemplateFundingEmail varchar(50) default 'Funding Email'