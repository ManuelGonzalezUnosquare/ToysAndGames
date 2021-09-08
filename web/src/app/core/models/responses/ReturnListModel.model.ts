export class ReturnListModel<T>{
  isSuccess:boolean=false;
  model: T[]=[];
  page:number=1;
  perPage:number=5;
  totalNumberOfRecords:number=0;
  error:string="";
}
