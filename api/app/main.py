from fastapi import FastAPI, Depends
from fastapi.middleware.cors import CORSMiddleware
from sqlalchemy.orm import Session

from .database import Base, engine, wait_for_db, get_db
from .routers import products
from . import models, schemas

wait_for_db()
Base.metadata.create_all(bind=engine)

app = FastAPI(title="Backend API")

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],  # ajusta esto cuando tengas la app Avalonia en producción
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

app.include_router(products.router)


@app.get("/", response_model=list[schemas.ProductRead])
def root(db: Session = Depends(get_db)):
    return db.query(models.Product).all()


@app.get("/health")
def health():
    return {"status": "ok"}