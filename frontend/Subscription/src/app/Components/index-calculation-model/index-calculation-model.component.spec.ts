import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndexCalculationModelComponent } from './index-calculation-model.component';

describe('IndexCalculationModelComponent', () => {
  let component: IndexCalculationModelComponent;
  let fixture: ComponentFixture<IndexCalculationModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndexCalculationModelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IndexCalculationModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
