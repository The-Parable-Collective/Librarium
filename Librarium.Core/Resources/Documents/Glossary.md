## Atomic
An **atomic** action is one that effectively happens all at once.
An **atomic** action cannot stop in the middle: it either happens completely, or it doesn't happen at all.
No side effects of an **atomic** action are visible until the action is complete.


## Child-recursive
Any action that calls a version of itself on its children. Ex: A.DoThing calls A.Child.DoThing.
This type of recursion traverses down the parent-child relationship tree until it reaches the desired level, breaks out, or reaches the bottom of the tree. Can be used to construct, deconstruct, or transform heirarchical data.

## List-Atomic
A method that is **List-Atomic** either adds to a collection before it's enumerated or after, but never during, and enumerating through the list will always enumerate through the whole list and never break early.
Taken from the definition for **atomic**, meaning all-or-nothing.


## Non-pop:
A method that is **non-pop** will not enumerate the collection (pop the collection query) it is provided. **Where** for example, is a **non-pop** method. This is often referred to as "Deferred execution", where the logic of the methods don't actually fire until an enumeration (pop) is invoked.

## Pop
A method that is **pop** will enumerate the collection (pop the collection query) it is provided. **FirstOrDefault** for example, is a pop method.
JetBrains refers to this as **InstantHandle**, though this may have a slightly different meaning on, for example, delegates.