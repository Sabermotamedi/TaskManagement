export interface Task {

    id: number;
    name : string;
    description : string;
    type: TaskType;
    priority : PriorityLevel;
    status: StatusState;
    // dueDate : Date;
}

export enum TaskType {
    Task = 0,
    SubTask = 1,
    Story = 2,
    Bug = 3,
    Change = 4
}

export enum StatusState {
    Unknown,
    BackLog,
    ToDo,
    InProgress,
    Done
}

export enum PriorityLevel {
    NiceToHave = 0,
    Low,
    Medium,
    High,
}