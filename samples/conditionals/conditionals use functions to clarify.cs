//// Conditional, use functions to clarify conditions
// Mal
if (fsm.state == "fetching" && isEmpty(listNode))
{
    // ...
}
// Bien
public bool ShouldShowSpinner(Fsm fsm, ListNode listNode)
{
    return fsm.state == "fetching" && IsEmpty(listNode);
}
if (ShouldShowSpinner(fsmInstance, listNodeInstance))
{
    // ...
}


