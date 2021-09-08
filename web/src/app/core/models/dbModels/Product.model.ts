import {BaseModel} from "./BaseModel.model";
import {Company} from "./Company.model";

export interface Product extends BaseModel{
  name:string;
  description:string;
  ageRestriction:string;
  company: Company;
  price:number;
  pic:string;
  picThumbnail:string;
}
