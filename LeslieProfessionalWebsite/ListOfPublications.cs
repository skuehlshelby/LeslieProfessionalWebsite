using System.Collections;

namespace LeslieProfessionalWebsite
{
    public class ListOfPublications : ICollection<Publication>
    {
        private readonly Publication[] publications;

        public ListOfPublications()
        {
            publications = new Publication[]
            {
                new Publication(
                    url: @"https://doi.org/10.3389/fenvs.2019.00184",
                    title: "Greenhouse- and Field-Measured Plant-Soil Feedbacks Are Not Correlated",
                    authors: "Leslie Forero, Josephine Grenzer, Johannes Heinze, Conrad Schittko, and Andrew Kulmatiski",
                    datePublished: new DateOnly(2019, 11, 26),
                    journal: "Frontiers in Environmental Science",
                    @abstract: @"Plant-soil feedbacks (PSFs) have become a commonly invoked mechanism of plant
                    coexistence and abundance. Yet, most PSF experiments have been performed in
                    greenhouse conditions. To test whether or not greenhouse-measured PSF values are
                    of similar magnitude and positively correlated with field-measured PSFs, we compared
                    PSF values from five different studies that measured PSF values in both greenhouse and
                    field conditions. For 36 plant species, greenhouse-measured PSF values were larger than
                    and not positively correlated with field-measured PSF values. Similarly, these 36 species
                    produced 269 soil-specific PSF values, and for each site there was no positive correlation
                    between these greenhouse- and field-measured PSF values.While PSFs were observed
                    in both greenhouse and field conditions, results provided no support at the soil, site or
                    species level that a positive correlation exists between greenhouse- and field-measured
                    PSF. Further, greenhouse-measured PSF appear to overestimate field-measured PSF.
                    Although from five studies, results strongly suggest that field experiments are needed to
                    understand the role of PSFs in plant communities in natural settings.",
                    isOpenAccess: true,
                    downloadLink: @"greenhouse-and-field-measured-plant-soil-feedback.pdf"),

                new Publication(
                    url: @" https://doi.org/10.1038/S42003-021-02329-1",
                    title: "Plant-soil feedbacks help explain biodiversity-productivity relationships",
                    authors: "Leslie Forero, Andrew Kulmatiski, Josephine Grenzer, and Jeanette Norton",
                    datePublished: new DateOnly(2021, 6, 25),
                    journal: "Communications Biology",
                    @abstract: @"Species-rich plant communities can produce twice as much aboveground biomass as
                    monocultures, but the mechanisms remain unresolved. We tested whether plant-soil feed-
                    backs (PSFs) can help explain these biodiversity-productivity relationships. Using a 16-species, 
                    factorial field experiment we found that plants created soils that changed subsequent
                    plant growth by 27% and that this effect increased over time. When incorporated into
                    simulation models, these PSFs improved predictions of plant community growth and
                    explained 14% of overyielding. Here we show quantitative, field-based evidence that diversity
                    maintains productivity by suppressing plant disease. Though this effect alone was modest, it
                    helps constrain the role of factors, such as niche partitioning, that have been difficult to
                    quantify. This improved understanding of biodiversity-productivity relationships has implications
                    for agriculture, biofuel production and conservation.",
                    isOpenAccess: true,
                    downloadLink: @"plant-soil-feedbacks-help-explain-biodiversity.pdf"),

                new Publication(
                    url: @"https://doi.org/10.1002/ECE3.7819",
                    title: "Moderate plant–soil feedbacks have small effects on the biodiversity–productivity relationship: A field experiment",
                    authors: "Josephine Grenzer, Andrew Kulmatiski, Leslie Forero, Anne Ebeling, Nico Eisenhauer, Jeanette Norton",
                    datePublished: new DateOnly(2021, 6, 6),
                    journal: "Ecology and Evolution",
                    @abstract: @"Plant–soil feedback (PSF) has gained attention as a mechanism promoting plant
                    growth and coexistence. However, most PSF research has measured monoculture
                    growth in greenhouse conditions. Translating PSFs into effects on plant growth in
                    field communities remains an important frontier for PSF research. Using a 4-year,
                    factorial field experiment in Jena, Germany, we measured the growth of nine grassland
                    species on soils conditioned by each of the target species (i.e., 72 PSFs). Plant
                    community models were parameterized with or without these PSF effects, and model
                    predictions were compared to plant biomass production in diversity–productivity
                    experiments. Plants created soils that changed subsequent plant biomass by 40%.
                    However, because they were both positive and negative, the average PSF effect was
                    14% less growth on “home” than on “away” soils. Nine-species plant communities
                    produced 29 to 37% more biomass for polycultures than for monocultures due primarily
                    to selection effects. With or without PSF, plant community models predicted
                    28%–29% more biomass for polycultures than for monocultures, again due primarily
                    to selection effects. Synthesis: Despite causing 40% changes in plant biomass, PSFs
                    had little effect on model predictions of plant community biomass across a range of
                    species richness. While somewhat surprising, a lack of a PSF effect was appropriate
                    in this site because species richness effects in this study were caused by selection
                    effects and not complementarity effects (PSFs are a complementarity mechanism).
                    Our plant community models helped us describe several reasons that even large PSF
                    may not affect plant productivity. Notably, we found that dominant species 
                    demonstrated small PSF, suggesting there may be selective pressure for plants to create
                    neutral PSF. Broadly, testing PSFs in plant communities in field conditions provided a
                    more realistic understanding of how PSFs affect plant growth in communities in the
                    context of other species traits.",
                    isOpenAccess: true,
                    downloadLink: @"moderate-plant–soil-feedbacks-have-small-effects.pdf"),

                 new Publication(
                    url: @"https://doi.org/10.1007/s11104-021-04844-w",
                    title: "Bagging: a cheaper, faster, non-destructive transpiration water sampling method for tracer studies",
                    authors: "Andrew Kulmatiski, Leslie Forero",
                    datePublished: new DateOnly(2021, 2, 8),
                    journal: "Plants and Soil",
                    @abstract: @"Stable isotope tracer experiments provide a
                    powerful tool for understanding plant root distributions,
                    resource uptake, niche partitioning and water cycling.
                    Plant water is typically collected from pre-transpiring
                    tissues to avoid the effects of evaporative isotope 
                    enrichment at the leaf surface, but extracting water from
                    these plant samples is difficult and expensive. The purpose
                    of this study was to test a simple transpiration
                    bagging approach for measuring hydrologic tracer
                    uptake. Sampling was performed as part of a depth-
                    specific tracer experiment in which 2H2O was injected
                    to target depths (5, 15, 30, 60, or 150 cm) in different
                    replicated plots. One day following injections, leaves
                    from three species were sealed in bags for 16 h and
                    transpired water was collected. Water from pre-transpiring
                    stem tissue was then collected in a separate
                    set of samples and extracted using cryogenic distillation.
                    Results Deuterium concentrations from the two techniques
                    were correlated (R2 = 0.84) and both approaches
                    produced similar descriptions of vertical root distributions
                    for three dominant plant species. 18O concentrations
                    from the two techniques were not correlated.
                    Conclusion Bagging transpired water produced similar
                    estimates of 2H tracer uptake as the standard sampling
                    technique. Bagging requires no destructive sampling,
                    specialized laboratory equipment, training or consumables
                    and is expected to halve sampling costs. While
                    effective in this tracer experiment, bagging may be not
                    be effective in natural abundance experiments, or tracer
                    experiments with very small plants or small transpiration
                    rates (i.e., early-season or arid sites).",
                    isOpenAccess: true,
                    downloadLink: @"bagging-a-cheaper-faster-non-destructive.pdf"),

                 new Publication(
                    url: @"https://doi.org/10.1002/ecy.2011",
                    title: "Live long and prosper: plant–soil feedback, lifespan, and landscape abundance covary",
                    authors: "Andrew Kulmatiski, Karen Beard, Jeanette Norton, Justin Heavilin, Leslie Forero, and Josephine Grenzer",
                    datePublished: new DateOnly(2017, 12, 8),
                    journal: "Ecology",
                    @abstract: @"Plant soil feedbacks (PSFs) are thought to be important to plant growth and
                    species coexistence, but most support for these hypotheses is derived from short-term green-
                    house experiments. Here we use a seven-year, common garden experiment to measure PSFs for
                    seven native and six nonnative species common to the western United States. We use these
                    long-term, field-based estimates to test correlations between PSF and plant landscape abun-
                    dance, species origin, functional type, and lifespan. To assess potential PSF mechanisms, we
                    also measured soil microbial community composition, root biomass, nitrogen cycling, bulk
                    density, penetration resistance, and shear strength. Plant abundance on the landscape and
                    plant lifespan were positively correlated with PSFs, though this effect was due to the relation-
                    ships for native plants. PSFs were correlated with indices of soil microbial community compo-
                    sition. Soil nutrient and physical traits and root biomass differed among species but were not
                    correlated with PSF. While results must be taken with caution because only 13 species were
                    examined, these species represent most of the dominant plant species in the system. Results
                    suggest that native plant abundance is associated with the ability of long-lived plants to create
                    positive plant–soil microbe interactions, while short-lived nonnative plants maintain domi-
                    nance by avoiding soil-borne antagonists, increasing nitrogen cycling and dedicating resources
                    to aboveground growth and reproduction rather than to belowground growth. Broadly, results
                    suggest that PSFs are correlated with a suite of traits that determine plant abundance.",
                    isOpenAccess: true,
                    downloadLink: @"live-long-and-prosper-plant-soil-feedback.pdf"),

                 new Publication(
                    url: @"https://doi.org/10.1890/15-2037.1",
                    title: "Using plant-soil feedbacks to predict plant biomass in diverse communities",
                    authors: "Andrew Kulmatiski, Karen Beard, Josephine Grenzer, Leslie Forero, and Justin Heavilin",
                    datePublished: new DateOnly(2016, 3, 28),
                    journal: "Ecology",
                    @abstract: @"It has become clear that plants can create soils that affect subsequent plant
                    growth. However, because plant-soil feedbacks (PSFs) are typically measured in monoculture
                    experiments, it remains unclear to what extent PSFs affect plant growth in communities.
                    Here we used data from a factorial PSF experiment to predict the biomass of 12
                    species grown in 162 plant community combinations. Five different plant growth models
                    were parameterized with either monoculture biomass data (Null) or with PSF data (PSF)
                    and model predictions were compared to plant growth observed in communities. For each
                    of the five models, PSF model predictions were closer to observed species biomass in
                    communities than Null model predictions. PSFs, which were associated with a 28% difference
                    in plant biomass across soil types, explained 10% more variance than Null models.
                    Results provided strong support for a small role for PSFs in predicting plant growth in
                    communities and suggest several reasons that PSFs, as traditionally measured in monoculture
                    experiments, may overestimate PSF effects in communities. First, monoculture data
                    used in Null models inherently includes “self ” PSF effects. Second, PSFs must be large
                    relative to differences in intrinsic growth rates among species to change competitive outcomes.
                    Third, PSFs must vary among species to change species relative abundances.",
                    isOpenAccess: true,
                    downloadLink: @"using-plant-soil-feedbacks-to-predict-plant-biomass.pdf"),

                 new Publication(
                    url: @"https://doi.org/10.3733/ca.2016a0019",
                    title: "Calf and yearling prices in California and the western United States",
                    authors: "Tina Saitone, Larry Forero, Glenn Nader and Leslie Forero",
                    datePublished: new DateOnly(2016, 11, 16),
                    journal: "California Agriculture",
                    @abstract: @"This paper investigates spatial, quality and temporal factors impacting 
                    the pricing of calves and yearlings in the western United States using data from a 
                    satellite video auction and a hedonic regression framework. Results suggest that spatial
                    price discounts received by western ranchers closely match reported shipping costs and, 
                    thus, are consistent with free-on-board pricing and competitive procurement. This study 
                    also identifies the presence of temporal price premiums, on average, for seller-offered 
                    forward contracts at video auctions. With respect to quality attributes, this study provides 
                    estimates of the marginal value associated with various quality attributes and management practices, 
                    including vaccination protocols, weaning, certified Angus beef candidates, and age and source verification. 
                    Finally, we show that the considerable year-to-year variability in estimated valuations for value-added 
                    attributes in hedonic regression models of cattle pricing can be linked to the stage of 
                    the cattle cycle, with premiums paid by buyers being attenuated when cattle inventories are high.",
                    isOpenAccess: true,
                    downloadLink: @"calf-and-yearling-prices-in-california-and-the-west.pdf")
            }.
            OrderByDescending(p => p.DatePublished).
            ToArray();
        }

        public int Count => ((ICollection<Publication>)publications).Count;

        public bool IsReadOnly => ((ICollection<Publication>)publications).IsReadOnly;

        public void Add(Publication item)
        {
            ((ICollection<Publication>)publications).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Publication>)publications).Clear();
        }

        public bool Contains(Publication item)
        {
            return ((ICollection<Publication>)publications).Contains(item);
        }

        public void CopyTo(Publication[] array, int arrayIndex)
        {
            ((ICollection<Publication>)publications).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Publication> GetEnumerator()
        {
            return ((IEnumerable<Publication>)publications).GetEnumerator();
        }

        public bool Remove(Publication item)
        {
            return ((ICollection<Publication>)publications).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return publications.GetEnumerator();
        }
    }
}
