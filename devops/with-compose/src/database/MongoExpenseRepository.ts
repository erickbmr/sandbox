import { Expense, IExpenseRepository } from './IExpenseRepository';
import { ExpenseModel } from '../models/ExpenseModel';

export class MongoExpenseRepository implements IExpenseRepository {
  async create(name: string, value: number): Promise<Expense> {
    const doc = await ExpenseModel.create({ name, value });
    return { name: doc.name, value: doc.value };
  }

  async findAll(): Promise<Expense[]> {
    const docs = await ExpenseModel.find({}, { _id: 0, name: 1, value: 1 });
    return docs.map((d) => ({ name: d.name, value: d.value }));
  }
}
