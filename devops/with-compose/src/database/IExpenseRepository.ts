export interface Expense {
  name: string;
  value: number;
}

export interface IExpenseRepository {
  create(name: string, value: number): Promise<Expense>;
  findAll(): Promise<Expense[]>;
}
