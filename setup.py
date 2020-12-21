import setuptools
from setuptools import setup, Extension, distutils, find_packages

with open("README.md", "r", encoding="utf-8") as fh:
    long_description = fh.read()

setuptools.setup(
    name="SiriusN16CXRseg", 
    version="0.0.2",
    author="Sirius_nauka16",
    author_email="dkhasanov76@gmail.com",
    description="Проект по сегментации легких.",
    long_description=long_description,
    long_description_content_type="text/markdown",
    url="https://github.com/SenpaiBabai/CXRsegmentation",
    packages = find_packages(),
    package_data = {
        'CXRsegmentation': [
            'trained_models/Model_lungs_heart',
        ]
    },
    classifiers=[
        "Programming Language :: Python :: 3",
        "License :: OSI Approved :: Apache Software License",
        "Operating System :: OS Independent",
    ],
    python_requires='>=3.6.9',
)

