import { TestBed } from '@angular/core/testing';

import { CompanyDeleteService } from './company-delete.service';

describe('CompanyDeleteService', () => {
  let service: CompanyDeleteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CompanyDeleteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
