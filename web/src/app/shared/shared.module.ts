import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { SearchbarComponent } from './layout/searchbar/searchbar.component';
import { MaterialModule } from '../material/material.module';
import { MenubarComponent } from './layout/menubar/menubar.component';
import { WorkInProgressComponent } from './pages/work-in-progress/work-in-progress.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    NavbarComponent,
    SearchbarComponent,
    MenubarComponent,
    WorkInProgressComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    RouterModule
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule,
    NavbarComponent,
    SearchbarComponent,
    MenubarComponent,
    WorkInProgressComponent
  ]
})
export class SharedModule { }
