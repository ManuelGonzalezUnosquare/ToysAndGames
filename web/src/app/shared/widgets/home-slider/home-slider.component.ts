import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-slider',
  templateUrl: './home-slider.component.html',
  styleUrls: ['./home-slider.component.scss'],
})
export class HomeSliderComponent implements OnInit {
  /* images: [*/
  /*{ path: 'https://i.blogs.es/5efe2c/cap_001/1366_2000.jpg' },*/
  /*{ path: 'https://images.pexels.com/photos/34577/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260' },*/
  /*{ path: 'https://images.pexels.com/photos/230544/pexels-photo-230544.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260' },*/
  /*{*/
  /*path: 'https://images.pexels.com/photos/919436/pexels-photo-919436.jpeg?cs=srgb&dl=pexels-andrea-piacquadio-919436.jpg&fm=jpg';*/
  /*},*/
  /*{*/
  /*path: 'https://images.pexels.com/photos/35550/ipad-tablet-technology-touch.jpg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260';*/
  /*}*/
  /*];*/

  images = [
    { path: 'assets/images/banner/banner1.jpg' },
    { path: 'assets/images/banner/banner2.jpg' },
    { path: 'assets/images/banner/banner3.jpg' },

  ];

  constructor() {}

  ngOnInit(): void {}
}
