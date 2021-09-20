import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { MaterialModule } from '../material/material.module';
import { MenubarComponent } from './layout/menubar/menubar.component';
import { WorkInProgressComponent } from './pages/work-in-progress/work-in-progress.component';
import { RouterModule } from '@angular/router';
import { SearchComponent } from './widgets/search/search.component';
import { StopPropagationDirective } from './directives/stop-propagation.directive';



@NgModule({
  declarations: [
    NavbarComponent,
    MenubarComponent,
    WorkInProgressComponent,
    SearchComponent,
    StopPropagationDirective
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    RouterModule,
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule,
    NavbarComponent,
    MenubarComponent,
    WorkInProgressComponent,
    SearchComponent,
    StopPropagationDirective
  ]
})
export class SharedModule { }
