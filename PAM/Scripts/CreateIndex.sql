﻿CREATE FULLTEXT CATALOG ftCatalog AS DEFAULT;  
GO

CREATE FULLTEXT INDEX ON AuditLog(Message)   
   KEY INDEX PK_AuditLog
   WITH STOPLIST = SYSTEM;  
GO  
