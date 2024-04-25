package com.example.taskmanagement.util;

import com.example.taskmanagement.model.Task;
import com.example.taskmanagement.service.TaskService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class TaskFacade {

  private final TaskService taskService;

  @Autowired
  public TaskFacade(TaskService taskService) {
    this.taskService = taskService;
  }

  public Task createTask(String name, String description) {
    Task task = new Task();
    task.setName(name);
    task.setDescription(description);
    return taskService.createTask(task);
  }
}
