1. Any library member should be able to search books 
by their title, author, subject category as well 
by the publication date.

2. Each book will have a unique identification number 
and other details including a rack number which 
will help to physically locate the book.

3. There could be more than one copy of a book,
and library members should be able to check-out
and reserve any copy. We will call each copy of
a book, a book item.

4. The system should be able to retrieve information
like who took a particular book or what are the
books checked-out by a specific library member.

5. There should be a maximum limit (5) on how many
books a member can check-out.

6. There should be a maximum limit (10) on how 
many days a member can keep a book.

7. The system should be able to collect fines
for books returned after the due date.

8. Members should be able to reserve books that
are not currently available.

9. The system should be able to send notifications
whenever the reserved books become available, as
well as when the book is not returned within
the due date.

10. Each book and member card will have a 
unique barcode. The system will be able to read
barcodes from books and members’ library cards.

Process flow:
As a User:
1. Scan the member library card
2. Retrieve personal member details 
3. Check number of books already checkedOut
4. Decide whether you can get more
5. Check fines for the books
6. Search for books - Builder pattern to construct the search obj?

As an Admin/ System:
1. Check which member has checkout which book(s)
2. How many books of a title is left
3. Read barcodes of members and bookItems 
4. Send notifications - Observer pattern
