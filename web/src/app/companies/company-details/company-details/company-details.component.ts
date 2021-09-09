import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-company-details',
  templateUrl: './company-details.component.html',
  styleUrls: ['./company-details.component.scss']
})
export class CompanyDetailsComponent implements OnInit {
  title = 'New Company';
  constructor(private activatedRoute: ActivatedRoute) { 
    let guid = this.activatedRoute.snapshot.params.guid;
    if(guid){
      console.log("entro por aqui");
      this.title = 'Edit Company';
      //getCompanyById
    }
    else{

    }

  }

  ngOnInit(): void {
  }
  initializeForm(){
    
  }

}
