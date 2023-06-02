import { Component, OnInit } from '@angular/core';
import { Task } from 'src/app/models/tasks.model';
import { TasksService } from 'src/app/services/tasks.service';

@Component({
  selector: 'app-tasks-list',
  templateUrl: './tasks-list.component.html',
  styleUrls: ['./tasks-list.component.css'],
})
export class TasksListComponent implements OnInit {
  tasks: Task[] = [];

  constructor(private taskService: TasksService) {}
  ngOnInit(): void {
    this.taskService.getAllTasks().subscribe({
      next: (tasks) => {
        console.log(tasks);
        this.tasks = tasks;
      },
    });
  }
}
