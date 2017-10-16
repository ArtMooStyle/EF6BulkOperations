# EF6BulkOperations
EF6 bulk operations

How to use it

You just need to call the methods bellow for the feature you want to use passing the collection of entities to perform the operation.

context.BulkInsert(entities);
context.BulkUpdate(entities);
context.BulkInsertOrUpdate(entities);
context.BulkDelete(entities);

//Generated Ids are populated by adding the optional parammeter

context.BulkInsert(entities, InsertOptions.OutputIdentity);
context.BulkInsertOrUpdate(entities, InsertOptions.OutputIdentity);

//Computed columns are populated by adding the optional parammeter

context.BulkInsert(entityList, InsertOptions.OutputComputed);
context.BulkInsertOrUpdate(entityList, InsertOptions.OutputComputed);
context.BulkUpdate(entityList, UpdateOptions.OutputComputed);

//It is possible to combine options
context.BulkInsert(entityList, InsertOptions.OutputIdentity | InsertOptions.OutputComputed);
context.BulkInsertOrUpdate(entityList, InsertOptions.OutputIdentity | InsertOptions.OutputComputed);
Framework Targets

For EF6 you can use it with .NetFramewok 4.5+;
