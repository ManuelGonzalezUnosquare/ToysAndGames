import {BaseModel} from "./BaseModel.model";
import {Company} from "./Company.model";

export class Product extends BaseModel{
  name:string;
  description:string;
  ageRestriction:string;
  company: Company;
  price:number;
  pic:string;
  picThumbnail:string;
}
