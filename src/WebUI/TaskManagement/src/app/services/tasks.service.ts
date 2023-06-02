import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { Task } from '../models/tasks.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class TasksService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllTasks(): Observable<Task[]> {
    return this.http.get<Task[]>(this.baseApiUrl + 'task');
  }

  addTask(addTaskRequest: Task): Observable<Task> {
    return this.http.post<Task>(this.baseApiUrl + 'task',addTaskRequest);
  }

}
