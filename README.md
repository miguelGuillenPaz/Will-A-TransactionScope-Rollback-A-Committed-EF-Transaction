Will-A-TransactionScope-Rollback-A-Committed-EF-Transaction
===========================================================

This is a prototype to see if a TransactionScope can rollback a committed EntityFramework transaction so I can rollback data changes in an integration test.

Turns out, it does roll the whole thing back.  #hooray
