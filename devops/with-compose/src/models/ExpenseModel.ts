import { Schema, model } from 'mongoose';

const expenseSchema = new Schema({
  name: { type: String, required: true },
  value: { type: Number, required: true },
});

export const ExpenseModel = model('Expense', expenseSchema);
