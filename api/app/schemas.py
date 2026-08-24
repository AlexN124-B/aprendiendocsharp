from datetime import datetime
from decimal import Decimal
from pydantic import BaseModel


class ProductBase(BaseModel):
    title: str
    description: str | None = None
    price: Decimal
    category: str
    stock: int = 0


class ProductCreate(ProductBase):
    pass


class ProductUpdate(BaseModel):
    title: str | None = None
    description: str | None = None
    price: Decimal | None = None
    category: str | None = None
    stock: int | None = None


class ProductRead(ProductBase):
    id: int
    created_at: datetime
    updated_at: datetime

    class Config:
        from_attributes = True
