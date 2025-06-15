# SimpleCalculator

Overview
This project sets up a CI/CD pipeline for a simple WPF Calculator application using GitHub Actions. The pipeline builds the application, runs unit tests, performs CodeQL code analysis, reviews dependencies, publishes the application as a single executable, and uploads the build artifacts.

Project Setup

Pre-requisites

   1. Windows 10/11 Machine
   2. Visual Studio and .Net
   3. Git 
	
Steps

	1. Clone the repository - git clone https://github.com/vishnumm93/SimpleCalculator.git
	2. Open SimpleCalculator.sln in Visual Studio
	3. Run the application

Pipeline Design Decisions

	1. Platform:
		○ Runs on the latest Windows virtual environment to support building WPF applications.
	2. Build Triggers:
		○ Triggers on push, pull request, and manual workflow dispatch to support both CI and on-demand runs.
	3. Dependency Review:
		○ Reviews new or updated dependencies for security risks, especially for pull request workflows.
	4. CodeQL Integration:
		○ Performs static code analysis to identify potential security vulnerabilities.
	5. Publishing:
		○ Publishes the application as a self-contained, single executable for the win-x64 runtime compatible with Windows 10 and Windows 11.
	6. Artifact Upload:
		○ Uploads the published application for further distribution or manual testing with a 7-day retention period.

How to Run / Test the Pipeline

	1. Push to Main:
		○ Simply push changes to the main branch. This will automatically trigger the pipeline.
	2. Create a Pull Request:
		○ Opening or updating a pull request to main will also trigger the pipeline with additional dependency review steps.
	3. Manual Trigger:
		○ Use the workflow_dispatch option on GitHub to manually trigger the pipeline if needed.
	4. Artifact Download:
		○ After successful execution, download the Calculator-App artifact from the GitHub Actions summary page.

Future Scope of Improvements

	1. UI Automation Integration:
		○ Incorporate a UI automation framework capable of deploying builds to remote machines, including both physical devices and virtual machines, to perform end-to-end automated testing.
	2. Artifact Management & Deployment:
		○ Automate the process to publish successful builds to cloud storage solutions like Amazon S3 or Azure Blob Storage, ensuring easy access for distribution or further testing.
	3. Artifact Security Scanning:
		○ Implement automated security scans of build artifacts using VirusTotal APIs or enterprise-grade vulnerability scanning tools to ensure artifact safety before deployment.
	4. Failure Notifications:
		○ Configure automated alerts via Slack or email to notify teams immediately when test failures occur, improving response times.
        5. Environment Based Deployments:
		○ Deplyoment to staging or production environments.
	6. Centralized Log Management:
		○ Collect logs from test executions and build pipelines, and store them in a centralized logging system for traceability and diagnostics.
	7. Environment Cleanup:
		○ Introduce automated cleanup routines to tear down temporary environments, clear test data, and optimize resource usage after pipeline execution.


## Status
[![.NET WPF Pipeline](https://github.com/vishnumm93/SimpleCalculator/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/vishnumm93/SimpleCalculator/actions/workflows/dotnet-desktop.yml)

