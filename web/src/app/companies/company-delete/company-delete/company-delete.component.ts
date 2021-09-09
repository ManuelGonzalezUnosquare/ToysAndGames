import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-company-delete',
  templateUrl: './company-delete.component.html',
  styleUrls: ['./company-delete.component.scss']
})
export class CompanyDeleteComponent implements OnInit {
  constructor(private activatedRoute: ActivatedRoute, private router: Router) { 
    let guid = this.activatedRoute.snapshot.params.guid;
    if(!guid){
      this.router.navigate(['/companies']);
    }
  }

  ngOnInit(): void {
  }
  getCompanyByGuid():void{
    
  }

}
