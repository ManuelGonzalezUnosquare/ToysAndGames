import {BaseModel} from "./BaseModel.model";
import {Product} from "./Product.model";

export interface Company extends BaseModel{
  name:string;
  products:Product[];
}
