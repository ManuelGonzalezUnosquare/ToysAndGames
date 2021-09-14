import {BaseModel} from "./BaseModel.model";
import {Product} from "./Product.model";

export class Company extends BaseModel{
  name:string;
  products:Product[];
}
