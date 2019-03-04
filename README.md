# EF6BulkOperations

EF6 bulk operations

How to use it : 

```csharp
context.BulkInsert(entities);
context.BulkUpdate(entities);
context.BulkInsertOrUpdate(entities);
context.BulkDelete(entities);
```

Perfomance

BuldSaveChanges - 5000 entities around 500ms 

Framework Targets : 

For EF6 you can use it with .NetFramewok 4.5+;


