import os
import time
from sqlalchemy import create_engine
from sqlalchemy.exc import OperationalError
from sqlalchemy.orm import sessionmaker, declarative_base
from dotenv import load_dotenv

load_dotenv()

DATABASE_URL = os.getenv(
    "DATABASE_URL",
    "mysql+pymysql://admin:admin123@mariadb:3306/products_db"
)

engine = create_engine(DATABASE_URL, pool_pre_ping=True)
SessionLocal = sessionmaker(autocommit=False, autoflush=False, bind=engine)
Base = declarative_base()


def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()


def wait_for_db(max_retries: int = 10, delay: int = 2):
    for attempt in range(1, max_retries + 1):
        try:
            with engine.connect():
                return
        except OperationalError:
            print(f"BBDD no disponible todavía (intento {attempt}/{max_retries}), reintentando en {delay}s...")
            time.sleep(delay)
    raise RuntimeError("No se pudo conectar a la base de datos tras varios intentos")