import { Component, OnInit } from '@angular/core';
import { Task } from 'src/app/models/tasks.model';
import { TasksService } from 'src/app/services/tasks.service';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css'],
})
export class AddTaskComponent implements OnInit {

  addTaskRequest: Task = {
    id: 0,
    name: '',
    description: '',
    type: 0,
    priority: 0,
    status: 0    
  };

  ngOnInit(): void {}
  constructor(private taskService:TasksService) {}

  addTask() {
    console.log(this.addTaskRequest);
    this.taskService.addTask(this.addTaskRequest).subscribe()
  }
}
