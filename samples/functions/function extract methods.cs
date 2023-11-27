//// Function, extract methods, avoid flag arguments
// Mal
public void CreateTask(string description, int priority, bool preview, bool email)
{
    var task = TaskFactory.New();
    task.Status = "open";
    task.Description = description;
    task.Priority = priority;

    if (!preview)
    {
        task.Save();
        if (email)
        {
            MailSender.Send(task);
        }
    }
    else
    {
        MailSender.Send(task, false);
    }
}

// Bien
public Task CreateTask(string description, int priority)
{
    var task = TaskFactory.New(description, priority);
    task.Save();
    return task;
}

public Task PreviewTask(string description, int priority)
{
    var task = TaskFactory.New(description, priority);
    return task;
}

public void NotifyTaskCreation(Task task)
{
    EmailSender.NotifyCreation(task);
}

public void NotifyTaskPreview(Task task)
{
    EmailSender.NotifyCreation(task);
}
