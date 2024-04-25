package com.example.taskmanagement.service.impl;

import com.example.taskmanagement.model.Task;
import com.example.taskmanagement.service.TaskService;
import java.util.ArrayList;
import java.util.List;
import org.springframework.stereotype.Service;

@Service
public class TaskServiceImpl implements TaskService {

  private final List<Task> tasks = new ArrayList<>();

  @Override
  public List<Task> getAllTasks() {
    return tasks;
  }

  @Override
  public Task createTask(Task task) {
    return null;
  }

  @Override
  public Task getTaskById(Long id) {
    return null;
  }

  @Override
  public Task updateTask(Long id, Task task) {
    return null;
  }

  @Override
  public void deleteTask(Long id) {

  }

  @Override
  public void addTask(Task task) {
    tasks.add(task);
  }
}