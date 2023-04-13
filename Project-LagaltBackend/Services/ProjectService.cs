﻿using Project_LagaltBackend.Exceptions;
using Microsoft.EntityFrameworkCore;
using Project_LagaltBackend.Data;
using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Services
{
    public class ProjectService : IProjectService
    {
        private readonly LagaltDbContext _context;

        public ProjectService(LagaltDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetProjectById(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
            {
                throw new ProjectNotFoundException(id);
            }

            return project;
        }

        public async Task<Project> UpdateProject(Project project)
        {
            var searchedProject = await _context.Projects.FindAsync(project.Id);
            if (searchedProject == null)
            {
                throw new ProjectNotFoundException(project.Id);
            }

            await _context.SaveChangesAsync();
            return project;
        }

        public async Task<Project> AddProject(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return project;
        }

        public async Task DeleteProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                throw new ProjectNotFoundException(id);
            }

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
    }
}
