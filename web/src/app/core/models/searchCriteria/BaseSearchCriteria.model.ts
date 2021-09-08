import {ReturnListModel} from './../responses/ReturnListModel.model';
export class BaseSearchCriteria {
  guid:string;
  page:number = 1;
  perPage:number =  5;
  active?:boolean =  true;
  totalNumberOfRecords:number = 0;

  loadResultList(result: ReturnListModel<any>){
    this.page = result.page;
    this.perPage = result.perPage;
    this.totalNumberOfRecords = result.totalNumberOfRecords;
  }
}
